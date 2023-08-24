using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIRAMA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void searchMatr_Click(object sender, EventArgs e)
        {
            string matricule = matricul_input.Text;
            
            if (matricul_input.Text.Length < 6 )
            {
                
                affNom.Text = "Le numero matricule doit être composé de 6 chiffres!!!";
                affNom.ForeColor = Color.Red;
            }
            else
            {
                affNom.Text = matricule;
                affNom.ForeColor = Color.Green;
            }
        }

        private void affNom_Click(object sender, EventArgs e)
        {
            MessageBox.Show(matricul_input.Text);
        }
    }
}
