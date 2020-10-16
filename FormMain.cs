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
    #region Les constantes
        //Les textes des MessageBox dans des constantes
        private const string STRSAISIEINVALIDE = "Saisie invalide";
        private const string STRSAISIE0 = "Cette valeur doit être différente de 0";
        private const string STRREDUCTIONIMPOSSIBLE = "Il n'est pas possible de réduire cette fraction.";
        private const string STRFRACTIONEGAL1 = "Cette fraction = 1.";
        
        //Les titre des MessageBox dans des constantes
        private const string STRTITREERREUR = "Erreur";
        private const string STRTITREINFORMATION = "Information";
        
        //Le texte du TextBox 
        private const string STRPGCD = "PGDC = ";
        
        //Les textes des tooltips
        private const string STRESTUNDIVISEURDE = " : est un diviseur de ";
        private const string STRFINTOOLTIP = ".\n";
        
        //Le texte empty
        private const string STREMPTY = "";
        
        //String du zero pour vérifier que la fraction ne contienne 
        private const string STR0 = "0";
      #endregion
      
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
                MessageBox.Show(STRSAISIEINVALIDE, STRTITREERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Numerateur.Text = STREMPTY;
                textBox_Numerateur.Focus();
                return;
            }
            // Conversion des nombres en long
            if (!decimal.TryParse(textBox_Denominateur.Text, out denominateur))
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show(STRSAISIEINVALIDE, STRTITREERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Denominateur.Text = STREMPTY;
                textBox_Denominateur.Focus();
                return;
            }
            // Est-ce que mon numérateur est égal à 0 ? (cette valeur doit être obligatoirement différente de 0)
            if (textBox_Numerateur.Text == STR0)
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show(STRSAISIE0, STRTITREERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Numerateur.Text = STREMPTY;
                textBox_Numerateur.Focus();
                return;
            }
            if (textBox_Denominateur.Text == STR0)
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show(STRSAISIE0, STRTITREERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                textBox_Denominateur.Text = STREMPTY;
                textBox_Denominateur.Focus();
                return;
            }
            // Est-ce que mon dénominateur est égal à 0 ? (cette valeur doit être obligatoirement différente de 0)
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
            textBox_PGDC.Text = STRPGCD + plusGrandDiviseurCommun;
            textBox_ResultNumerateur.Text = Convert.ToString(numerateur / plusGrandDiviseurCommun);
            textBox_ResultDenominateur.Text = Convert.ToString(denominateur / plusGrandDiviseurCommun);

            if (plusGrandDiviseurCommun == 1)
            {
                MessageBox.Show(STRREDUCTIONIMPOSSIBLE, STRTITREINFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numerateur == denominateur)
            {
                MessageBox.Show(STRFRACTIONEGAL1, STRTITREINFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //foreach (int itemk in ListDiviseurCommun)
            //{
            //    MessageBox.Show("Plus Grand Diviseur Commun : " + itemk);
            //}
            string bingo = STREMPTY;
            string binga = STREMPTY;
            foreach (int iteml in ListDiviseurNumerateur)
            {
                bingo += iteml + STRESTUNDIVISEURDE + numerateur + STRFINTOOLTIP;
            }
            foreach (int itemm in ListDiviseurDenominateur)
            {
                binga += itemm + STRESTUNDIVISEURDE + denominateur + STRFINTOOLTIP;
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
