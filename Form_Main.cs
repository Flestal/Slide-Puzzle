using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        Form_33 F_33;
        Form_44 F_44;
        Form_55 F_55;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            F_33 = new Form_33();
            F_33.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            F_44 = new Form_44();
            F_44.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            F_55 = new Form_55();
            F_55.Show();
        }
    }
}
