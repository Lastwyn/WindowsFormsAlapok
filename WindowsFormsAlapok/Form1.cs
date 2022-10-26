using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_udvozol_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(comboBox1.Text) || numericUpDown1.Value == 0 || listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Hiányzó adat, nem adott meg egy adatot", "Kérem adja meg a megfelelő adatokat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                MessageBox.Show("Sikeres adatbevitel" + " " + textBox1.Text + "\nÜdvözöllek!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
