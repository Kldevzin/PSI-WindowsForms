using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form2 : Form
    {
        public Form2(string usuario, string senha)
        {
            InitializeComponent();
            label1.Text = usuario;
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
