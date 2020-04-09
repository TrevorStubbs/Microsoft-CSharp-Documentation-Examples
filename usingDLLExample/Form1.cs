/* Code Based off of:
 * https://www.c-sharpcorner.com/UploadFile/1e050f/creating-and-using-dll-class-library-in-C-Sharp/
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;

namespace usingDLLExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Calculate cal = new Calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Add(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Sub(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
