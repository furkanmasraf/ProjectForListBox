using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Istanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Izmir");
            comboBox1.Items.Add("Kastamonu");
            comboBox1.Items.Add("Yalova");
            comboBox1.Items.Add("Eskisehir");
        }
    }
}
