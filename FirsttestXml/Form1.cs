using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirsttestXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox.Text = Xuly.test();
            txtbox.Text += "Những sinh viên có tuổi 22 \n";
            txtbox.Text += Xuly.tuoi();
        }
    }
}
