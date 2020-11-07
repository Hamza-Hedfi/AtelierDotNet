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
            //listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
            afficher_etat();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
            afficher_etat();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add($"{((RadioButton)sender).Name}={((RadioButton)sender).Checked}");
            afficher_etat();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
            afficher_etat();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
            afficher_etat();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add($"{((CheckBox)sender).Name}={((CheckBox)sender).Checked}");
            afficher_etat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficher_etat();
        }

        public void afficher_etat()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"{checkBox1.Name} : {checkBox1.Checked}");
            listBox1.Items.Add($"{checkBox2.Name} : {checkBox2.Checked}");
            listBox1.Items.Add($"{checkBox3.Name} : {checkBox3.Checked}");
            listBox1.Items.Add($"{radioButton1.Name} : {radioButton1.Checked}");
            listBox1.Items.Add($"{radioButton2.Name} : {radioButton2.Checked}");
            listBox1.Items.Add($"{radioButton3.Name} : {radioButton3.Checked}");
        }
    }
}
