namespace Project_2
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
            this.button_coin = new System.Windows.Forms.Button();
            this.button_die = new System.Windows.Forms.Button();
            this.button_gaussian = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.listBox_objects = new System.Windows.Forms.ListBox();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_coin
            // 
            this.button_coin.Location = new System.Drawing.Point(237, 111);
            this.button_coin.Name = "button_coin";
            this.button_coin.Size = new System.Drawing.Size(116, 28);
            this.button_coin.TabIndex = 0;
            this.button_coin.Text = "COIN";
            this.button_coin.UseVisualStyleBackColor = true;
            this.button_coin.Click += new System.EventHandler(this.button_coin_Click);
            // 
            // button_die
            // 
            this.button_die.Location = new System.Drawing.Point(237, 154);
            this.button_die.Name = "button_die";
            this.button_die.Size = new System.Drawing.Size(116, 28);
            this.button_die.TabIndex = 1;
            this.button_die.Text = "DIE";
            this.button_die.UseVisualStyleBackColor = true;
            this.button_die.Click += new System.EventHandler(this.button_die_Click);
            // 
            // button_gaussian
            // 
            this.button_gaussian.Location = new System.Drawing.Point(237, 198);
            this.button_gaussian.Name = "button_gaussian";
            this.button_gaussian.Size = new System.Drawing.Size(116, 28);
            this.button_gaussian.TabIndex = 2;
            this.button_gaussian.Text = "GAUSSIAN";
            this.button_gaussian.UseVisualStyleBackColor = true;
            this.button_gaussian.Click += new System.EventHandler(this.button_gaussian_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(237, 243);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(116, 28);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // listBox_objects
            // 
            this.listBox_objects.FormattingEnabled = true;
            this.listBox_objects.Location = new System.Drawing.Point(33, 59);
            this.listBox_objects.Name = "listBox_objects";
            this.listBox_objects.Size = new System.Drawing.Size(155, 212);
            this.listBox_objects.TabIndex = 4;
            this.listBox_objects.SelectedIndexChanged += new System.EventHandler(this.listBox_objects_SelectedIndexChanged);
            // 
            // textBox_seed
            // 
            this.textBox_seed.Location = new System.Drawing.Point(237, 59);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(115, 20);
            this.textBox_seed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Objects:";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(236, 319);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(116, 28);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 359);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.listBox_objects);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_gaussian);
            this.Controls.Add(this.button_die);
            this.Controls.Add(this.button_coin);
            this.Name = "Form1";
            this.Text = "Pseudo Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_coin;
        private System.Windows.Forms.Button button_die;
        private System.Windows.Forms.Button button_gaussian;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ListBox listBox_objects;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
    }
}

