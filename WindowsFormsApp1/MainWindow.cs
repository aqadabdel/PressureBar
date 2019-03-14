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

using System.Diagnostics;
using System.Timers;
using System.Globalization;

namespace PressureBar
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timr;
        Stopwatch sw;
        string[] ports = SerialPort.GetPortNames();
        int interval = 1;
        SerialPort sp = new SerialPort();
        System.IO.StreamWriter csv;
        StringBuilder outputLines = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


            if (ports.Count() > 0)
            {
                foreach (string port in ports)
                {
                    cb_port.Items.Add(port);
                    Console.WriteLine(port);
                }
                cb_port.SelectedText = ports[0];
                sp.BaudRate = 9600;
                sp.PortName = ports[0];
                sp.DtrEnable = true;

            }
            int[] intervals = { 1, 2, 5, 10, 15 };

            foreach (int interval in intervals)
            {
                cb_interval.Items.Add(interval);
            }
            cb_interval.SelectedText = intervals[0].ToString();


        }


        private void btn_start_Click(object sender, EventArgs e)
        {


            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le port " + sp.PortName.ToString() + " ne peut pas être ouvert.\n" +
                    " Veuillez choisir le bon port série.");
                Console.WriteLine("Error opening serial port " + ex.ToString());
                return;
            }
            lbl_time.ForeColor = System.Drawing.Color.Black;
            string userpath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\";

            timr = new System.Windows.Forms.Timer();
            timr.Interval = (1000);
            timr.Tick += new EventHandler(timer_Tick);
            sw = new Stopwatch();
            timr.Start();
            sw.Start();

            btn_start.Text = "Started";
            btn_stop.Text = "Stop";

            lbl_time.Text = String.Format("{0:hh\\:mm\\:ss}", sw.Elapsed);

            // System.IO.Directory.CreateDirectory("z:\\Desktop\\OUTPUT_PRESSURE");
            System.IO.Directory.CreateDirectory(userpath + "OUTPUT_PRESSURE");
            DateTime date_now = DateTime.Now;
            string suffix = DateTime.Now.ToString("dd_MM_yyyy__hh_mm_ss");
            csv = new System.IO.StreamWriter(userpath + "OUTPUT_PRESSURE\\PRESSURE_" + suffix + ".csv");
            outputLines.AppendLine("\"TEMPS\";\"VALEUR MBAR\"");
            //csv.WriteLine("\"TEMPS\";\"VALEUR MBAR\"");

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = String.Format("{0:hh\\:mm\\:ss}", sw.Elapsed);


            if (Math.Round(sw.Elapsed.TotalSeconds) % interval == 0)
            {
                string mbar = sp.ReadLine();
                if (mbar == "")
                {
                    Console.WriteLine("INVALID SERIAL INPUT");
                }
                else
                {
                    //string mbar = "0, 3.6000E-03 mbar";
                    string raw_value = mbar.Substring(3, 10);
                    string value = mbar.Substring(3, 6);
                    float val = float.Parse(value, CultureInfo.InvariantCulture);

                    int exp = int.Parse(mbar.Substring(10, 3));

                    decimal mbar_value = (int)(val * Math.Pow(10, exp)); ;

                    if (exp <= 0)
                    {
                        mbar_value = (decimal)val;
                        mbar_value = decimal.Round(mbar_value, 2);
                        if (exp < 0)
                        {
                            lbl_exp.Text = "x10^" + exp.ToString();
                        }
                    }
                    else
                    {
                        lbl_exp.Text = "";
                    }

                    //    Console.WriteLine("VAL: " + raw_value);
                    //  Console.WriteLine("MBAR: " + mbar_value.ToString());
                    lbl_mbar.Text = mbar_value.ToString();
                    string formated_time = String.Format("{0:hh\\:mm\\:ss}", sw.Elapsed);
                    //  Console.Write(" " + formated_time + "    " + mbar_value + " mBar RAW: " + raw_value + " mbar");
                    outputLines.AppendLine("\"" + formated_time + "\";\"" + raw_value + "\"");
                    //csv.WriteLine("\"" + formated_time + "\";\"" + raw_value + "\"");
                }
            }

            Application.DoEvents();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            lbl_time.ForeColor = System.Drawing.Color.OrangeRed;
            btn_start.Text = "Start";
            btn_stop.Text = "Stopped";

            try
            {
                csv.Write(outputLines.ToString());
                timr.Stop();
                sw.Stop();
                sp.Close();
                csv.Close();
                csv.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing serial port " + ex.ToString());
                return;
            }


        }

        private void cb_interval_SelectedIndexChanged(object sender, EventArgs e)
        {
            interval = int.Parse(cb_interval.Text);
            Console.WriteLine(interval.ToString());
        }

        private void cb_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp.PortName = cb_port.Text;
        }


    }
}
