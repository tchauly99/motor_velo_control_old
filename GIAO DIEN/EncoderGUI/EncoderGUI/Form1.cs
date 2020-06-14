using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using ZedGraph;

namespace EncoderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            port_name.DataSource= SerialPort.GetPortNames();
            baud_rate.SelectedIndex = 7;
            data_bits.SelectedIndex = 5;
            parity.SelectedIndex = 0;
            stop_bits.SelectedIndex = 1;
            encoder_mode.SelectedIndex = 1;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(receive_data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graph_setup();
        }

        delegate void data_processing_call(int text);
        int receive_status=0;
        /* 
         receive_status:
         0: idle
         1: receive direction
         2: receive high byte of speed
         3: receive low byte of speed
         4: x1/x4
         5: receive high byte of position
         6: receive low byte of position
         7: set home
         8: x1/x4
        */
        int speed_setpoint, position_setpoint, pulse_setpoint;
        double current_speed, current_position;
        byte setpoint_type=251;
        /*
         setpoint:
         251: set speed
         252: set position
        */
        bool current_direction,direction_setpoint;
        /*
         current_direction:
         0: forward
         1: reverse
        */
        bool sethome;
        /*
         sethome:
         0: not setting home
         1: set home at the next control period
        */
        int buffer;
        double t=0;
        List<double> time_buffer = new List<double>();
        List<double> setpoint_buffer = new List<double>();
        List<double> data_buffer = new List<double>();
        // time

        private void graph_setup()
        {
            string graph_type_text="",unit="";
            int min = 0, max = 0;
            if (setpoint_type==252)
            {
                graph_type_text = "Position";
                unit = " degree";
                min = 0;
                max = 359;
            }
            else if (setpoint_type==251)
            {
                graph_type_text = "Speed";
                unit = "rpm";
                min = -10;
                max = 10;
            }
            GraphPane pane = graph.GraphPane;
            pane.Title.Text = graph_type_text + " Graph";
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 20;
            pane.XAxis.Title.Text = "Time(s)";
            pane.YAxis.Scale.Min = min;
            pane.YAxis.Scale.Max = max;
            pane.YAxis.Title.Text = graph_type_text;
            pane.AxisChange();
            RollingPointPairList setpoint_list = new RollingPointPairList(60000);
            RollingPointPairList data_list = new RollingPointPairList(60000);
            LineItem setpoint_curve = pane.AddCurve("Setpoint", setpoint_list, Color.Blue, SymbolType.None);
            LineItem data_curve = pane.AddCurve(graph_type_text, data_list, Color.Red, SymbolType.None);
            graph.Invalidate();
            graph.Refresh();
        }

        private void clear_graph()
        {
            t = 0;
            time_buffer.Clear();
            setpoint_buffer.Clear();
            data_buffer.Clear();
            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();
        }

        private void update_graph_data(double time, double setpoint_value, double data_value)
        {
            if (graph.GraphPane.CurveList.Count <= 0)
                return;
            LineItem setpoint_curve = graph.GraphPane.CurveList[0] as LineItem;
            if (setpoint_curve == null)
                return;
            IPointListEdit setpoint_list = setpoint_curve.Points as IPointListEdit;
            if (setpoint_curve == null)
                return;
            setpoint_list.Add(time, setpoint_value);


            if (graph.GraphPane.CurveList.Count <= 1)
                return;
            LineItem data_curve = graph.GraphPane.CurveList[1] as LineItem;
            if (data_curve == null)
                return;
            IPointListEdit data_list = data_curve.Points as IPointListEdit;
            if (data_curve == null)
                return;
            data_list.Add(time, data_value);

            Scale x_scale = graph.GraphPane.XAxis.Scale;
            Scale y_scale = graph.GraphPane.YAxis.Scale;
            if (time > x_scale.Max - 5)
            {
                x_scale.Max = time + 5;
                x_scale.Min = x_scale.Max - 25;
            }
            if (setpoint_value > y_scale.Max - 10)
            {
                y_scale.Max = setpoint_value + 10;
            }
            if (data_value > y_scale.Max - 10)
            {
                y_scale.Max = data_value + 10;
            }
            if (setpoint_value < y_scale.Min + 10)
            {
                y_scale.Min = setpoint_value - 10;
            }
            if (data_value < y_scale.Min + 10)
            {
                y_scale.Min = data_value - 10;
            }
        }

        private void catchup ()
        {
            while (time_buffer.Count > 0)
            {
                update_graph_data(time_buffer[0], setpoint_buffer[0], data_buffer[0]);
                time_buffer.RemoveAt(0);
                setpoint_buffer.RemoveAt(0);
                data_buffer.RemoveAt(0);
            }
            draw();
        }
        private void draw()
        {
            graph.AxisChange();
            graph.Validate();
            graph.Refresh();
        }

        private void receive_data (object ob,SerialDataReceivedEventArgs e)
        {
            int data_received = serialPort1.ReadByte();
            process_data(data_received);
        }
        private void process_data(int data_received)
        {
            if (terminal.InvokeRequired)
            {
                data_processing_call d = new data_processing_call(process_data);
                this.Invoke(d, new object[] { data_received });
            }
            else
            {
                int a = data_received;
                //terminal.Text += Convert.ToString(a) + "\n";
                if (data_received == 251)
                    receive_status = 1;
                else if (data_received == 252)
                    receive_status = 5;
                else
                {
                    switch (receive_status)
                    {
                        case 1:
                            if (data_received == 0)
                                current_direction = false;
                            else
                                current_direction = true;
                            receive_status = 2;
                            break;
                        case 2:
                            buffer = data_received*250;
                            receive_status = 3;
                            break;
                        case 3:
                            buffer += data_received;
                            receive_status = 4;
                            break;
                        case 4:
                            if (!current_direction)
                                current_direction_display.Text = "forward";
                            else
                                current_direction_display.Text = "reverse";
                            pulse_number_display.Text = Convert.ToString(buffer);
                            if (data_received == 1)
                            {
                                current_speed = buffer*8;
                            }
                            else if (data_received == 4)
                            {
                                current_speed = buffer*2;
                            }
                            current_speed_display.Text = Convert.ToString(current_speed);
                            if (setpoint_type==251)
                            {
                                t = t + 0.1;
                                if (hold.Checked==true)
                                {
                                    if (current_direction)
                                        data_buffer.Add(-current_speed);
                                    else
                                        data_buffer.Add(current_speed);
                                    time_buffer.Add(t);
                                    if (direction_setpoint)
                                        setpoint_buffer.Add(-speed_setpoint);
                                    else 
                                        setpoint_buffer.Add(speed_setpoint);
                                }
                                else
                                {
                                    if (direction_setpoint & current_direction)
                                        update_graph_data(t, -speed_setpoint, -current_speed);
                                    else if (direction_setpoint & (!current_direction))
                                        update_graph_data(t, -speed_setpoint, current_speed);
                                    else if ((!direction_setpoint) & current_direction)
                                        update_graph_data(t, speed_setpoint, -current_speed);
                                    else if ((!direction_setpoint) & (!current_direction))
                                        update_graph_data(t, speed_setpoint, current_speed);
                                    draw();
                                }
                            }
                            receive_status = 0;
                            break;
                        case 5:
                            buffer = data_received*250;
                            receive_status = 6;
                            break;
                        case 6:
                            buffer += data_received;
                            receive_status = 7;
                            current_position_display.Text = Convert.ToString(buffer);
                            break;
                        case 7:
                            receive_status = 8;
                            break;
                        case 8:
                            current_position = buffer;
                            if (setpoint_type == 252)
                            {
                                t = t + 0.1;
                                if (hold.Checked==true)
                                {
                                    time_buffer.Add(t);
                                    setpoint_buffer.Add(position_setpoint);
                                    data_buffer.Add(current_position);
                                }
                                else
                                {
                                    update_graph_data(t, position_setpoint, current_position);
                                    graph.AxisChange();
                                    graph.Validate();
                                    graph.Refresh();
                                    draw();
                                }
                            }
                            receive_status = 0;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private int get_int(string int_string)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(int_string);
            }
            catch (FormatException)
            {
                MessageBox.Show("This isn't an integer.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The integer is too large.");
            }
            return (i);
        }

        private void send_data()
        {
            byte[] data = new byte[5];
            data[0] = setpoint_type;
            switch (setpoint_type)
            {
                case 251:
                    if (direction.Checked)
                    {
                        data[1] = 1;
                        direction_setpoint = true;
                    }
                    else
                    {
                        data[1] = 0;
                        direction_setpoint = false;
                    }
                    if (encoder_mode.Text == "x1")
                        pulse_setpoint = speed_setpoint / 8;
                    else
                        pulse_setpoint = speed_setpoint / 2;
                    pulse_setpoint_display.Text = Convert.ToString(pulse_setpoint);
                    data[2] = Convert.ToByte(pulse_setpoint / 250);
                    data[3] = Convert.ToByte(pulse_setpoint % 250);
                    break;
                case 252:
                    data[1] = Convert.ToByte(position_setpoint / 250);
                    data[2] = Convert.ToByte(position_setpoint % 250);
                    if (sethome)
                        data[3] = 1;
                    else
                        data[3] = 0;
                    sethome = false;
                    break;
            }
            if (encoder_mode.Text == "x1")
                data[4] = 1;
            else
                data[4] = 4;
            terminal.Text += BitConverter.ToString(data)+"\n";
            byte[] a = {Convert.ToByte(251)};
            terminal.Text += Encoding.UTF8.GetString(a) + "\n";
            serialPort1.Write(data,0,data.Length);
        }
        
        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = port_name.Text;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please, enter the port name.");
            }
            catch (IOException)
            {
                MessageBox.Show("Port not found.");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Serial port is running.");
            }
            
            serialPort1.BaudRate = get_int(baud_rate.Text);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parity.Text);
            serialPort1.DataBits = get_int(data_bits.Text);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop_bits.Text);
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    connection_status.Text = "connected";
                }
                catch
                {
                    MessageBox.Show("Port name is invalid.");
                }
            }
            else
            {
                connection_status.Text = "connected";
            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                connection_status.Text = "disconnected";
            }
            else
            {
                connection_status.Text = "connected";
            }
        }

        private void get_port_button_Click(object sender, EventArgs e)
        {
            port_name.DataSource = SerialPort.GetPortNames();
            //port_name.Items.Clear();
            //port_name.Items.AddRange(SerialPort.GetPortNames());
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                send_data();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void set_speed_Click(object sender, EventArgs e)
        {
            speed_setpoint = get_int(speed_setpoint_entry.Text);
            if (setpoint_type != 251)
            {
                setpoint_type = 251;
                clear_graph();
                graph_setup();
            }
            try
            {
                send_data();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void clear_graph_button_Click(object sender, EventArgs e)
        {
            clear_graph();
            graph_setup();
        }

        private void hold_CheckedChanged(object sender, EventArgs e)
        {
            if (hold.Checked)
                catchup();
        }

        private void set_position_Click(object sender, EventArgs e)
        {
            position_setpoint = get_int(position_setpoint_entry.Text);
            if (setpoint_type != 252)
            {
                setpoint_type = 252;
                clear_graph();
                graph_setup();
            }
            try
            {
                send_data();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void set_home_Click(object sender, EventArgs e)
        {
            sethome = true;
        }
    }
}
