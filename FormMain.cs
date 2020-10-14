using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diviseurs_TP5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click Sur Btn "Calculer" :
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Calculer_Click(object sender, EventArgs e)
        {
            decimal numerateur;
            decimal denominateur;
            List<int> ListDiviseurNumerateur = new List<int>();
            List<int> ListDiviseurDenominateur = new List<int>();
            List<int> ListDiviseurCommun = new List<int>();

            // Conversion des nombres en long
            if (!decimal.TryParse(textBox_Numerateur.Text, out numerateur))
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Numerateur.Text = "";
                textBox_Numerateur.Focus();
                return;
            }
            // Conversion des nombres en long
            if (!decimal.TryParse(textBox_Denominateur.Text, out denominateur))
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Denominateur.Text = "";
                textBox_Denominateur.Focus();
                return;
            }
            // Faire les listes des diviseurs : 
            for (int i = 1; i <= numerateur; i++)
            {
                if ((numerateur % i) == 0 )
                {
                    ListDiviseurNumerateur.Add(i);
                } 
            }
            for (int j = 1; j <= denominateur; j++)
            {
                if ((denominateur % j) == 0)
                {
                    ListDiviseurDenominateur.Add(j);
                }
            }
            
            foreach (int itemi in ListDiviseurNumerateur)
            {
                foreach (int itemj in ListDiviseurDenominateur)
                {
                    if (itemi == itemj)
                    {
                        ListDiviseurCommun.Add(itemi);
                    }
                }
            }

            int plusGrandDiviseurCommun = ListDiviseurCommun.Last();
            textBox_PGDC.Text = "PGDC = " + plusGrandDiviseurCommun;
            textBox_ResultNumerateur.Text = Convert.ToString(numerateur / plusGrandDiviseurCommun);
            textBox_ResultDenominateur.Text = Convert.ToString(denominateur / plusGrandDiviseurCommun);

            if (plusGrandDiviseurCommun == 1)
            {
                MessageBox.Show("Il n'est pas possible de réduire cette fraction.");
            }
            else if (numerateur == denominateur)
            {
                MessageBox.Show("Cette fraction = 1.");
            }

            //foreach (int itemk in ListDiviseurCommun)
            //{
            //    MessageBox.Show("Plus Grand Diviseur Commun : " + itemk);
            //}
            string bingo = "";
            string binga = "";
            foreach (int iteml in ListDiviseurNumerateur)
            {
                bingo += iteml + " : est un diviseur de " + numerateur + ".\n";
            }
            foreach (int itemm in ListDiviseurDenominateur)
            {
                binga += itemm + " : est un diviseur de " + denominateur + ".\n";
            }

            toolTip1.SetToolTip(textBox_ResultNumerateur, bingo);
            toolTip1.SetToolTip(textBox_ResultDenominateur, binga);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Denominateur.Clear();
            textBox_Numerateur.Clear();
            textBox_PGDC.Clear();
            textBox_ResultDenominateur.Clear();
            textBox_ResultNumerateur.Clear();
            textBox_Numerateur.Focus();
        }
    }
}
