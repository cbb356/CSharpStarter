using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTypesBoundaries
{
    public partial class IntegralTypes : Form
    {
        public IntegralTypes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button1.Text} is {byte.MinValue} to {byte.MaxValue}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button2.Text} is {sbyte.MinValue} to {sbyte.MaxValue}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button3.Text} is {short.MinValue} to {short.MaxValue}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button4.Text} is {ushort.MinValue} to {ushort.MaxValue}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button5.Text} is {int.MinValue} to {int.MaxValue}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button6.Text} is {uint.MinValue} to {uint.MaxValue}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button7.Text} is {long.MinValue} to {long.MaxValue}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The range of {button8.Text} is {ulong.MinValue} to {ulong.MaxValue}");
        }
    }
}
