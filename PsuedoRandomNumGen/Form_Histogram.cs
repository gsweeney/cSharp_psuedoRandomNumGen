using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_2
{
    public partial class Form_Histogram : Form
    {
        private aRandomNumberGenerator obj_1;
        private int[] data;
        private int sum;
        private bool show_numbers;

        /// <summary>
        /// create a new Histogram form object
        /// </summary>
        /// <param name="obj_2"></param>
        public Form_Histogram()
        {
            InitializeComponent();
        }

        public void load(aRandomNumberGenerator obj_2)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            listBox_numbers.Items.Clear();

            obj_1 = obj_2;
            data = new int[37];
            sum = 0;
            label_total_gen.Text = sum.ToString();
            show_numbers = true;
            button_see.Enabled = false;
            button_clear.Enabled = true;

            label_total_gen.Text = obj_1.High.ToString();

            chart1.ChartAreas.Add("a");
            chart1.ChartAreas[0].AxisX.Minimum = obj_1.Low;
            chart1.ChartAreas[0].AxisX.Maximum = obj_1.High;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Interval = 10;

            Series ser1 = new Series("count");
            chart1.Series.Add(ser1);
            chart1.Series["count"].Points.AddXY(0, 0);
            chart1.Series["count"].SmartLabelStyle.Enabled = true;
            // format chart
            chart1.Titles.Add("Psuedorandom Number Generator for a " + obj_1.Type);
            chart1.ChartAreas[0].AxisX.Title = "possible numbers";
            chart1.ChartAreas[0].AxisY.Title = "number of times generated";
            this.Text = "Histogram for " + obj_1.Type + " Object";

            // load previous data
            load_previous_data();
            // sum total numbers generated
            label_total_gen.Text = sum.ToString();
        }

        /// <summary>
        /// if data previously generated, load that data into the Form
        /// </summary>
        public void load_previous_data() 
        {
            if (obj_1.numbers.Count > 0)
            {
                for (int i = obj_1.Low; i <= obj_1.High; i++)
                {
                    data[i] = obj_1.mydata[i];
                    chart1.Series["count"].Points.AddXY(i, obj_1.mydata[i]);
                    sum += obj_1.mydata[i];
                }
                int[] nums = obj_1.numbers.ToArray();
                listBox_numbers.Items.AddRange(nums.Cast<object>().ToArray());
            }
        }

        /// <summary>
        /// generate random number and update tracking data, chart
        /// </summary>
        public void display_data() 
        {
            // generate random number
            int num;
            num = obj_1.Next();
            // add the number to object's list of numbers
            obj_1.numbers.Add(num);
            // increment count in object's data store
            obj_1.mydata[num] = data[num] + 1;
            // increment total numbers generated and display
            sum += 1;

            // add to listbox, if it's active
            if (show_numbers) { listBox_numbers.Items.Add(num); }
            
            // update the histogram with the new data
            data[num] = data[num] + 1;
            label_total_gen.Text = sum.ToString();
            chart1.Series["count"].Points.AddXY(num, data[num]);
        }

        /// <summary>
        /// timer event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            display_data();
        }

        /// <summary>
        /// event handler, on click, show the numbers generated in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_see_Click(object sender, EventArgs e)
        {
            show_numbers = true;
            int[] nums = obj_1.numbers.ToArray();
            listBox_numbers.Items.AddRange(nums.Cast<object>().ToArray());
            button_see.Enabled = false;
            button_clear.Enabled = true;
        }

        /// <summary>
        /// event handler, on click, clear listbox of numbers generated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            show_numbers = false;
            button_see.Enabled = true;
            button_clear.Enabled = false;
            listBox_numbers.Items.Clear();
        }
    }
}
