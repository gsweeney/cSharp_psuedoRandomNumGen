using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        // fields
        List<aRandomNumberGenerator> objects = new List<aRandomNumberGenerator>();
        Form_Histogram histogram;

        public Form1()
        {
            InitializeComponent();
            button_stop.Enabled = false;
            histogram = new Form_Histogram();
            histogram.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selected object index
            int index = listBox_objects.SelectedIndex;

            // change the form window using object selected
            if(index >= 0 && objects[index] != null){
                // enable stop button
                button_stop.Enabled = true;

                // make listBox inactive
                listBox_objects.Enabled = false;
                histogram.load(objects[index]);
                histogram.timer.Start();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_coin_Click(object sender, EventArgs e)
        {
            // create new coin object - pass seed to constructor
            aCoin coin;
            string str = textBox_seed.Text;
            int parse_test, seed;
            if (int.TryParse(str, out parse_test))
            {
                seed = int.Parse(str);
                coin = new aCoin(seed);
                objects.Add(coin);
                listBox_objects.Items.Add("Coin");
            }
            else if(String.IsNullOrEmpty(str)){
                coin = new aCoin();
                objects.Add(coin);
                listBox_objects.Items.Add("Coin");
            }
            else { 
                MessageBox.Show("Invalid seed.  Enter an Integer or nothing at all.");
                textBox_seed.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_die_Click(object sender, EventArgs e)
        {
            // create new dice object - pass seed to constructor
            aDie die;
            string str = textBox_seed.Text;
            int parse_test, seed;
            if (int.TryParse(str, out parse_test))
            {
                seed = int.Parse(str);
                die = new aDie(seed);
                objects.Add(die);
                listBox_objects.Items.Add("Die");
            }
            else if (String.IsNullOrEmpty(str))
            {
                die = new aDie();
                objects.Add(die);
                listBox_objects.Items.Add("Die");
            }
            else
            {
                MessageBox.Show("Invalid seed.  Enter an Integer or nothing at all.");
                textBox_seed.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gaussian_Click(object sender, EventArgs e)
        {
            // create new dice object - pass seed to constructor
            aGaussian gaussian;
            string str = textBox_seed.Text;
            int parse_test, seed;
            if (int.TryParse(str, out parse_test))
            {
                seed = int.Parse(str);
                gaussian = new aGaussian(seed);
                objects.Add(gaussian);
                listBox_objects.Items.Add("Gaussian");
            }
            else if (String.IsNullOrEmpty(str))
            {
                gaussian = new aGaussian();
                objects.Add(gaussian);
                listBox_objects.Items.Add("Gaussian");
            }
            else
            {
                MessageBox.Show("Invalid seed.  Enter an Integer or nothing at all.");
                textBox_seed.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            histogram.timer.Stop();
            // make listBox active - only one generator running at a time
            listBox_objects.Enabled = true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
