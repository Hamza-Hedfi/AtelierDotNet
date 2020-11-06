using System;
using System.Windows.Forms;

namespace TP04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
        }
    }
}
