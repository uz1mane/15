using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{
    public partial class Form1 : Form
    {
        public int days, x;
        public double[] Theory = { 0, 0, 0 };
        public double log, curTime;
        public string weatherNow;
        public Random rnd = new Random();
        double[,] matrix = new double[3, 3] {
            { -0.4, 0.3, 0.1 },
            { 0.4, -0.8, 0.4 },
            { 0.1, 0.4, -0.5 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (curTime >= days * 24)
            {
                timer1.Stop();
            } else {
                curTime++;
                values();
                chart1.Series[0].Points.AddXY(curTime, x + 1);
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            days = (int)daysNumUpDown.Value;
            weatherNow = "";

            curTime = 0;

            if (clearBtn.Checked && !rainyBtn.Checked && !cloudBtn.Checked)
            {
                weatherNow = "clear";
                x = 0;
            }
            if (cloudBtn.Checked && !clearBtn.Checked && !rainyBtn.Checked)
            {
                weatherNow = "cloud";
                x = 1;
            }
            if (rainyBtn.Checked && !cloudBtn.Checked && !clearBtn.Checked)
            {
                weatherNow = "rain";
                x = 2;
            }
            chart1.Series[0].Points.AddXY(0, x + 1);
            timer1.Start();
        }

        private void statBtn_Click(object sender, EventArgs e)
        {
            double currentTime = 0;
            Theory[0] = 0;
            Theory[1] = 0;
            Theory[2] = 0;
            double [] Current = new double[3];
            int n = (int)nNumUpDown.Value;
            for (int k = 0; k < n; k++)
            {
                values();
                Theory[x] += log;
                currentTime += 1 / log;
            }
            for (int i = 0; i < 3; i++)
            {
                Current[i] = Theory[i] / currentTime;
            }
            currLabel.Text = "Current: \n" +
                "p1" + " = " + Current[0] + "\n" +
                "p2" + " = " + Current[1] + "\n" +
                "p3" + " = " + Current[2] + "\n";
            theoryLabel.Text = "Theoretical:\n" +
                "p1 = " + (1 / 3 - 3 * Current[2]) + "\n" +
                "p2 = " + (2 * Current[2] - 1 / 3) + "\n" +
                "p3 = " + Current[2];
        }

        public void values()
        {
            double rand = rnd.NextDouble();
            while (rand == 0)
            {
                rand = rnd.NextDouble();
            }
            double rand1 = rnd.NextDouble();
            log = Math.Log(rand) / matrix[x, x];
            int i;
            for (i = -1; rand1 > 0; i++)
            {
                if ((i + 1) != x)
                {
                    rand1 += (double)(matrix[x, i + 1] / matrix[x, x]);
                }
            }
            x = i;
        }
    }
}
