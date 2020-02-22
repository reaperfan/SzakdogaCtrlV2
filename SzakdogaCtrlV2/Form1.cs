using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SzakdogaCtrlV2
{
    public partial class Form1 : XtraForm
    {
        Stopwatch stopwatch;
        double allsecs;
        double prevsess;
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor("hearth.ico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            timer1.Enabled = true;
            allsecs = LoadAll();
            TimeSpan ts = TimeSpan.FromSeconds(allsecs);

            // Format and display the TimeSpan value.
            timeLbl.Text = String.Format("{3} {4} \n{0:00}:{1:00}:{2:00}",
                 ts.Hours, ts.Minutes, ts.Seconds, ts.Days, "nap");
            totalHrLbl.Text = String.Format("{0:00} {1}",
                 ts.TotalHours,"óra");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text == "Start")
            {
                stopwatch.Start();
                simpleButton1.Text = "Stop";

            }
            else
            {
                stopwatch.Stop();
                simpleButton1.Text = "Start";
                SaveTime(stopwatch.Elapsed);
                prevsess = stopwatch.Elapsed.TotalSeconds;
                TimeSpan ts2 = TimeSpan.FromSeconds(prevsess);

                stopwatch.Reset();
                double allstop = LoadAll();
                TimeSpan ts = TimeSpan.FromSeconds(allstop);

                // Format and display the TimeSpan value.
                timeLbl.Text = String.Format("{3} {4} \n{0:00}:{1:00}:{2:00}",
                 ts.Hours, ts.Minutes, ts.Seconds, ts.Days, "nap");
                
                totalHrLbl.Text = String.Format("{0:00} {1}",
                 ts.TotalHours, "óra");

                prevSess.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                 ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            sessionLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                 ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveTime(TimeSpan secs)
        {
            double session = secs.TotalSeconds;

            double allsecs = LoadAll();

            double sumsecs = session + allsecs;

            try
            {
                if (!Directory.Exists(@"c:\temp\"))
                {
                    Directory.CreateDirectory(@"c:\temp");
                }
                File.WriteAllText(@"c:\temp\Timespent.txt", sumsecs.ToString());
            }
            catch (Exception e )
            {

                XtraMessageBox.Show("Váratlan esemény" + e.Message);
            }
        }
        private double LoadAll()
        {
            try
            {
                if (File.Exists(@"c:\temp\Timespent.txt"))
                {
                    string[] lines = File.ReadAllLines(@"c:\temp\Timespent.txt");
                    return Convert.ToDouble(lines[0]);
                }
                else
                {

                    return 0;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Váratlan hiba, az adatok betöltésekor!" + e.Message);
                return 0;
            }
        }
        private bool ExitApp()
        {
            if (XtraMessageBox.Show("Biztosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitApp())
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
