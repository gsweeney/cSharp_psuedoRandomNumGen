namespace Project_2
{
    partial class Form_Histogram
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label_1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_total_gen = new System.Windows.Forms.Label();
            this.button_see = new System.Windows.Forms.Button();
            this.listBox_numbers = new System.Windows.Forms.ListBox();
            this.button_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(12, 26);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(156, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "Total Numbers Generated:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chart1
            // 
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 64);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(625, 464);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label_total_gen
            // 
            this.label_total_gen.AutoSize = true;
            this.label_total_gen.Location = new System.Drawing.Point(174, 26);
            this.label_total_gen.Name = "label_total_gen";
            this.label_total_gen.Size = new System.Drawing.Size(42, 13);
            this.label_total_gen.TabIndex = 3;
            this.label_total_gen.Text = "number";
            // 
            // button_see
            // 
            this.button_see.Location = new System.Drawing.Point(656, 17);
            this.button_see.Name = "button_see";
            this.button_see.Size = new System.Drawing.Size(80, 41);
            this.button_see.TabIndex = 4;
            this.button_see.Text = "Show Numbers";
            this.button_see.UseVisualStyleBackColor = true;
            this.button_see.Click += new System.EventHandler(this.button_see_Click);
            // 
            // listBox_numbers
            // 
            this.listBox_numbers.FormattingEnabled = true;
            this.listBox_numbers.Location = new System.Drawing.Point(656, 64);
            this.listBox_numbers.Name = "listBox_numbers";
            this.listBox_numbers.Size = new System.Drawing.Size(80, 420);
            this.listBox_numbers.TabIndex = 5;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(656, 490);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 41);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Hide Numbers";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(808, 540);
            this.ControlBox = false;
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listBox_numbers);
            this.Controls.Add(this.button_see);
            this.Controls.Add(this.label_total_gen);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label_1);
            this.Name = "Form_Histogram";
            this.Text = "Form_Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_total_gen;
        private System.Windows.Forms.Button button_see;
        private System.Windows.Forms.ListBox listBox_numbers;
        private System.Windows.Forms.Button button_clear;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}