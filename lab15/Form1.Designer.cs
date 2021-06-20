
namespace lab15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.theoryLabel = new System.Windows.Forms.Label();
            this.currLabel = new System.Windows.Forms.Label();
            this.daysNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.nNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.statBtn = new System.Windows.Forms.Button();
            this.rainyBtn = new System.Windows.Forms.RadioButton();
            this.cloudBtn = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1185, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // theoryLabel
            // 
            this.theoryLabel.AutoSize = true;
            this.theoryLabel.Location = new System.Drawing.Point(12, 470);
            this.theoryLabel.Name = "theoryLabel";
            this.theoryLabel.Size = new System.Drawing.Size(79, 17);
            this.theoryLabel.TabIndex = 1;
            this.theoryLabel.Text = "Theoretical";
            // 
            // currLabel
            // 
            this.currLabel.AutoSize = true;
            this.currLabel.Location = new System.Drawing.Point(219, 470);
            this.currLabel.Name = "currLabel";
            this.currLabel.Size = new System.Drawing.Size(55, 17);
            this.currLabel.TabIndex = 2;
            this.currLabel.Text = "Current";
            // 
            // daysNumUpDown
            // 
            this.daysNumUpDown.Location = new System.Drawing.Point(718, 470);
            this.daysNumUpDown.Name = "daysNumUpDown";
            this.daysNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.daysNumUpDown.TabIndex = 3;
            this.daysNumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nNumUpDown
            // 
            this.nNumUpDown.Location = new System.Drawing.Point(950, 470);
            this.nNumUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nNumUpDown.Name = "nNumUpDown";
            this.nNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.nNumUpDown.TabIndex = 4;
            this.nNumUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "N =";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(718, 516);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // statBtn
            // 
            this.statBtn.Location = new System.Drawing.Point(718, 565);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(75, 23);
            this.statBtn.TabIndex = 8;
            this.statBtn.Text = "Statistic";
            this.statBtn.UseVisualStyleBackColor = true;
            this.statBtn.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // rainyBtn
            // 
            this.rainyBtn.AutoSize = true;
            this.rainyBtn.Location = new System.Drawing.Point(950, 516);
            this.rainyBtn.Name = "rainyBtn";
            this.rainyBtn.Size = new System.Drawing.Size(58, 21);
            this.rainyBtn.TabIndex = 9;
            this.rainyBtn.TabStop = true;
            this.rainyBtn.Text = "Rain";
            this.rainyBtn.UseVisualStyleBackColor = true;
            // 
            // cloudBtn
            // 
            this.cloudBtn.AutoSize = true;
            this.cloudBtn.Location = new System.Drawing.Point(950, 544);
            this.cloudBtn.Name = "cloudBtn";
            this.cloudBtn.Size = new System.Drawing.Size(72, 21);
            this.cloudBtn.TabIndex = 10;
            this.cloudBtn.TabStop = true;
            this.cloudBtn.Text = "Clouds";
            this.cloudBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.Checked = true;
            this.clearBtn.Location = new System.Drawing.Point(950, 572);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(62, 21);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.TabStop = true;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 639);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cloudBtn);
            this.Controls.Add(this.rainyBtn);
            this.Controls.Add(this.statBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nNumUpDown);
            this.Controls.Add(this.daysNumUpDown);
            this.Controls.Add(this.currLabel);
            this.Controls.Add(this.theoryLabel);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label theoryLabel;
        private System.Windows.Forms.Label currLabel;
        private System.Windows.Forms.NumericUpDown daysNumUpDown;
        private System.Windows.Forms.NumericUpDown nNumUpDown;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button statBtn;
        private System.Windows.Forms.RadioButton rainyBtn;
        private System.Windows.Forms.RadioButton cloudBtn;
        private System.Windows.Forms.RadioButton clearBtn;
    }
}

