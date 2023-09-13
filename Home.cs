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
            point_panel.Hide();
            fact_panel.Hide();
            doc_panel.Hide();
            param_panel.Hide();
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

            if (matricul_input.Text.Length < 6)
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

        //---------------------------------- Changement de couleur bouton ---------------------------------- 

        private void pointagebtn_Click(object sender, EventArgs e)
        {
            pointagePanel.Show();
            point_Btn.BackColor = Color.Gray;
            point_Btn.ForeColor = Color.Black;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;

        }

        private void heuresup_click(object sender, EventArgs e)
        {
            pointagePanel.Hide();
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.Gray;
            heuresup_Btn.ForeColor = Color.Black;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;
        }

        private void affPres_Btn_Click(object sender, EventArgs e)
        {
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.Gray;
            affPres_Btn.ForeColor = Color.Black;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;
        }
        private void repartFact_Btn_Click(object sender, EventArgs e)
        {
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.Gray;
            repartFact_Btn.ForeColor = Color.Black;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;
        }

        private void zonerepart_Btn_Click(object sender, EventArgs e)
        {
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.Gray;
            zonerepart_Btn.ForeColor = Color.Black;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;
        }

        private void docreq_Btn_Click(object sender, EventArgs e)
        {
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.Gray;
            docreq_Btn.ForeColor = Color.Black;
            paramBtn.BackColor = Color.DarkSlateGray;
            paramBtn.ForeColor = Color.White;
        }

        private void paramBtn_Click(object sender, EventArgs e)
        {
            point_Btn.BackColor = Color.DarkSlateGray;
            point_Btn.ForeColor = Color.White;
            heuresup_Btn.BackColor = Color.DarkSlateGray;
            heuresup_Btn.ForeColor = Color.White;
            affPres_Btn.BackColor = Color.DarkSlateGray;
            affPres_Btn.ForeColor = Color.White;
            repartFact_Btn.BackColor = Color.DarkSlateGray;
            repartFact_Btn.ForeColor = Color.White;
            zonerepart_Btn.BackColor = Color.DarkSlateGray;
            zonerepart_Btn.ForeColor = Color.White;
            docreq_Btn.BackColor = Color.DarkSlateGray;
            docreq_Btn.ForeColor = Color.White;
            paramBtn.BackColor = Color.Gray;
            paramBtn.ForeColor = Color.Black;
        }

        //---------------------------------- Affichage menu ---------------------------------- 

        private void point_Ppl_Btn_Click(object sender, EventArgs e)
        {
            point_panel.Show();
            fact_panel.Hide();
            doc_panel.Hide();
            param_panel.Hide();
        }

        private void fact_Btn_Click(object sender, EventArgs e)
        {
            point_panel.Hide();
            fact_panel.Show();
            doc_panel.Hide();
            param_panel.Hide();
        }

        private void doc_Btn_Click(object sender, EventArgs e)
        {
            point_panel.Hide();
            fact_panel.Hide();
            doc_panel.Show();
            param_panel.Hide();
        }

        private void set_Btn_Click(object sender, EventArgs e)
        {
            point_panel.Hide();
            fact_panel.Hide();
            doc_panel.Hide();
            param_panel.Show();
        }


    }
}
