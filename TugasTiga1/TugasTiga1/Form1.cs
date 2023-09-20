using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NIM.Text = "NIM : 22.11.4819";
            Nama.Text = "Nama : Rezza Aprielartha Surya";
            Kelas.Text = "Kelas : IF 05";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NIM.Text = "NIM :";
            Nama.Text = "Nama :";
            Kelas.Text = "Kelas :";
        }
    }
}
