using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BoutonAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ekteb 7aja (¬_¬ )");
            }
        }

        private void BoutonVersListe2_Click(object sender, EventArgs e)
        {
            TransferItems(listBox1, listBox2);
        }

        private void BoutonVersListe1_Click(object sender, EventArgs e)
        {
            TransferItems(listBox2, listBox1);
        }

        private void TransferItems(ListBox source, ListBox destination)
        {
            var items = source.SelectedItems;
            foreach (var item in items)
            {
                destination.Items.Add(item);
            }
        }

        private void BoutonEffacerListe1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void BoutonEffacerListe2_Click(object sender, EventArgs e)
        {
            var items = listBox2.Items;
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }
    }
}
