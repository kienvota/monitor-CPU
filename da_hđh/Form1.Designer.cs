namespace da_hđh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.lbCPU = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbUpTime = new System.Windows.Forms.Label();
            this.pUpTime = new System.Diagnostics.PerformanceCounter();
            this.lbThread = new System.Windows.Forms.Label();
            this.pThread = new System.Diagnostics.PerformanceCounter();
            this.lbHandle = new System.Windows.Forms.Label();
            this.pHandle = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(132, 63);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(215, 23);
            this.progressBarCPU.TabIndex = 2;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(132, 107);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(215, 23);
            this.progressBarRAM.TabIndex = 3;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.Location = new System.Drawing.Point(366, 73);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(35, 13);
            this.lbCPU.TabIndex = 4;
            this.lbCPU.Text = "label3";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Location = new System.Drawing.Point(366, 117);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(35, 13);
            this.lbRAM.TabIndex = 5;
            this.lbRAM.Text = "label4";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(74, 136);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(545, 200);
            this.chart1.TabIndex = 6;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(89, 339);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(39, 13);
            this.lbSpeed.TabIndex = 7;
            this.lbSpeed.Text = "speed:";
            // 
            // lbUpTime
            // 
            this.lbUpTime.AutoSize = true;
            this.lbUpTime.Location = new System.Drawing.Point(89, 409);
            this.lbUpTime.Name = "lbUpTime";
            this.lbUpTime.Size = new System.Drawing.Size(50, 13);
            this.lbUpTime.TabIndex = 8;
            this.lbUpTime.Text = "Up Time:";
            this.lbUpTime.Click += new System.EventHandler(this.lbUpTime_Click);
            // 
            // pUpTime
            // 
            this.pUpTime.CategoryName = "System";
            this.pUpTime.CounterName = "System Up Time";
            // 
            // lbThread
            // 
            this.lbThread.AutoSize = true;
            this.lbThread.Location = new System.Drawing.Point(89, 376);
            this.lbThread.Name = "lbThread";
            this.lbThread.Size = new System.Drawing.Size(37, 13);
            this.lbThread.TabIndex = 9;
            this.lbThread.Text = "thread";
            // 
            // pThread
            // 
            this.pThread.CategoryName = "Process";
            this.pThread.CounterName = "Thread Count";
            this.pThread.InstanceName = "_Total";
            // 
            // lbHandle
            // 
            this.lbHandle.AutoSize = true;
            this.lbHandle.Location = new System.Drawing.Point(239, 376);
            this.lbHandle.Name = "lbHandle";
            this.lbHandle.Size = new System.Drawing.Size(39, 13);
            this.lbHandle.TabIndex = 10;
            this.lbHandle.Text = "handle";
            this.lbHandle.Click += new System.EventHandler(this.label3_Click);
            // 
            // pHandle
            // 
            this.pHandle.CategoryName = "Process";
            this.pHandle.CounterName = "Handle Count";
            this.pHandle.InstanceName = "_Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.lbHandle);
            this.Controls.Add(this.lbThread);
            this.Controls.Add(this.lbUpTime);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.lbCPU);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CPU MONITOR";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUpTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Label lbCPU;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbUpTime;
        private System.Diagnostics.PerformanceCounter pUpTime;
        private System.Windows.Forms.Label lbThread;
        private System.Diagnostics.PerformanceCounter pThread;
        private System.Windows.Forms.Label lbHandle;
        private System.Diagnostics.PerformanceCounter pHandle;
    }
}

