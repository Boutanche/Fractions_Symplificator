namespace Diviseurs_TP5
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_SaisieNumerateur = new System.Windows.Forms.Label();
            this.label_SaisieDenominateur = new System.Windows.Forms.Label();
            this.button_Calculer = new System.Windows.Forms.Button();
            this.label_resultat = new System.Windows.Forms.Label();
            this.label_ResultatNumerateur = new System.Windows.Forms.Label();
            this.label_ResultatDenominateur = new System.Windows.Forms.Label();
            this.groupBox_Resultat = new System.Windows.Forms.GroupBox();
            this.textBox_Numerateur = new System.Windows.Forms.TextBox();
            this.textBox_Denominateur = new System.Windows.Forms.TextBox();
            this.textBox_ResultNumerateur = new System.Windows.Forms.TextBox();
            this.textBox_ResultDenominateur = new System.Windows.Forms.TextBox();
            this.label_Separateur = new System.Windows.Forms.Label();
            this.label_ResultSeparateur = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_PGDC = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Titre = new System.Windows.Forms.Label();
            this.label_Credit = new System.Windows.Forms.Label();
            this.groupBox_Resultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SaisieNumerateur
            // 
            this.label_SaisieNumerateur.AutoSize = true;
            this.label_SaisieNumerateur.Location = new System.Drawing.Point(22, 59);
            this.label_SaisieNumerateur.Name = "label_SaisieNumerateur";
            this.label_SaisieNumerateur.Size = new System.Drawing.Size(145, 13);
            this.label_SaisieNumerateur.TabIndex = 0;
            this.label_SaisieNumerateur.Text = "Veuillez saisir le numérateur : ";
            // 
            // label_SaisieDenominateur
            // 
            this.label_SaisieDenominateur.AutoSize = true;
            this.label_SaisieDenominateur.Location = new System.Drawing.Point(22, 100);
            this.label_SaisieDenominateur.Name = "label_SaisieDenominateur";
            this.label_SaisieDenominateur.Size = new System.Drawing.Size(153, 13);
            this.label_SaisieDenominateur.TabIndex = 1;
            this.label_SaisieDenominateur.Text = "Veuillez saisir le dénominateur :";
            // 
            // button_Calculer
            // 
            this.button_Calculer.Location = new System.Drawing.Point(107, 141);
            this.button_Calculer.Name = "button_Calculer";
            this.button_Calculer.Size = new System.Drawing.Size(75, 23);
            this.button_Calculer.TabIndex = 3;
            this.button_Calculer.Text = "&Calculer";
            this.button_Calculer.UseVisualStyleBackColor = true;
            this.button_Calculer.Click += new System.EventHandler(this.button_Calculer_Click);
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Location = new System.Drawing.Point(19, 21);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(143, 13);
            this.label_resultat.TabIndex = 3;
            this.label_resultat.Text = "Résultat après simplification :";
            // 
            // label_ResultatNumerateur
            // 
            this.label_ResultatNumerateur.AutoSize = true;
            this.label_ResultatNumerateur.Location = new System.Drawing.Point(103, 62);
            this.label_ResultatNumerateur.Name = "label_ResultatNumerateur";
            this.label_ResultatNumerateur.Size = new System.Drawing.Size(68, 13);
            this.label_ResultatNumerateur.TabIndex = 4;
            this.label_ResultatNumerateur.Text = "Numérateur :";
            // 
            // label_ResultatDenominateur
            // 
            this.label_ResultatDenominateur.AutoSize = true;
            this.label_ResultatDenominateur.Location = new System.Drawing.Point(103, 103);
            this.label_ResultatDenominateur.Name = "label_ResultatDenominateur";
            this.label_ResultatDenominateur.Size = new System.Drawing.Size(79, 13);
            this.label_ResultatDenominateur.TabIndex = 5;
            this.label_ResultatDenominateur.Text = "Dénominateur :";
            // 
            // groupBox_Resultat
            // 
            this.groupBox_Resultat.Controls.Add(this.label_Credit);
            this.groupBox_Resultat.Controls.Add(this.textBox_PGDC);
            this.groupBox_Resultat.Controls.Add(this.label_ResultSeparateur);
            this.groupBox_Resultat.Controls.Add(this.textBox_ResultDenominateur);
            this.groupBox_Resultat.Controls.Add(this.textBox_ResultNumerateur);
            this.groupBox_Resultat.Controls.Add(this.label_ResultatDenominateur);
            this.groupBox_Resultat.Controls.Add(this.label_ResultatNumerateur);
            this.groupBox_Resultat.Controls.Add(this.label_resultat);
            this.groupBox_Resultat.Location = new System.Drawing.Point(4, 171);
            this.groupBox_Resultat.Name = "groupBox_Resultat";
            this.groupBox_Resultat.Size = new System.Drawing.Size(351, 161);
            this.groupBox_Resultat.TabIndex = 6;
            this.groupBox_Resultat.TabStop = false;
            this.groupBox_Resultat.Text = "Résultat";
            // 
            // textBox_Numerateur
            // 
            this.textBox_Numerateur.Location = new System.Drawing.Point(238, 59);
            this.textBox_Numerateur.Name = "textBox_Numerateur";
            this.textBox_Numerateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numerateur.TabIndex = 1;
            this.textBox_Numerateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Denominateur
            // 
            this.textBox_Denominateur.Location = new System.Drawing.Point(238, 100);
            this.textBox_Denominateur.Name = "textBox_Denominateur";
            this.textBox_Denominateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_Denominateur.TabIndex = 2;
            this.textBox_Denominateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ResultNumerateur
            // 
            this.textBox_ResultNumerateur.Location = new System.Drawing.Point(238, 62);
            this.textBox_ResultNumerateur.Name = "textBox_ResultNumerateur";
            this.textBox_ResultNumerateur.ReadOnly = true;
            this.textBox_ResultNumerateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_ResultNumerateur.TabIndex = 8;
            // 
            // textBox_ResultDenominateur
            // 
            this.textBox_ResultDenominateur.Location = new System.Drawing.Point(238, 103);
            this.textBox_ResultDenominateur.Name = "textBox_ResultDenominateur";
            this.textBox_ResultDenominateur.ReadOnly = true;
            this.textBox_ResultDenominateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_ResultDenominateur.TabIndex = 9;
            // 
            // label_Separateur
            // 
            this.label_Separateur.AutoSize = true;
            this.label_Separateur.Location = new System.Drawing.Point(240, 83);
            this.label_Separateur.Name = "label_Separateur";
            this.label_Separateur.Size = new System.Drawing.Size(97, 13);
            this.label_Separateur.TabIndex = 9;
            this.label_Separateur.Text = "_______________";
            // 
            // label_ResultSeparateur
            // 
            this.label_ResultSeparateur.AutoSize = true;
            this.label_ResultSeparateur.Location = new System.Drawing.Point(240, 86);
            this.label_ResultSeparateur.Name = "label_ResultSeparateur";
            this.label_ResultSeparateur.Size = new System.Drawing.Size(97, 13);
            this.label_ResultSeparateur.TabIndex = 10;
            this.label_ResultSeparateur.Text = "_______________";
            // 
            // textBox_PGDC
            // 
            this.textBox_PGDC.Location = new System.Drawing.Point(238, 21);
            this.textBox_PGDC.Name = "textBox_PGDC";
            this.textBox_PGDC.ReadOnly = true;
            this.textBox_PGDC.Size = new System.Drawing.Size(100, 20);
            this.textBox_PGDC.TabIndex = 11;
            this.textBox_PGDC.Text = "Le PGDC est  : ";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(280, 141);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "&Annuler";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Titre
            // 
            this.label_Titre.AutoSize = true;
            this.label_Titre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titre.Location = new System.Drawing.Point(13, 13);
            this.label_Titre.Name = "label_Titre";
            this.label_Titre.Size = new System.Drawing.Size(310, 23);
            this.label_Titre.TabIndex = 10;
            this.label_Titre.Text = "Simplification de fractions :";
            // 
            // label_Credit
            // 
            this.label_Credit.AutoSize = true;
            this.label_Credit.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Credit.Location = new System.Drawing.Point(6, 147);
            this.label_Credit.Name = "label_Credit";
            this.label_Credit.Size = new System.Drawing.Size(128, 11);
            this.label_Credit.TabIndex = 12;
            this.label_Credit.Text = "© By BiBi Informatique 2020";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 338);
            this.Controls.Add(this.label_Titre);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_Separateur);
            this.Controls.Add(this.textBox_Denominateur);
            this.Controls.Add(this.textBox_Numerateur);
            this.Controls.Add(this.groupBox_Resultat);
            this.Controls.Add(this.button_Calculer);
            this.Controls.Add(this.label_SaisieDenominateur);
            this.Controls.Add(this.label_SaisieNumerateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 377);
            this.MinimumSize = new System.Drawing.Size(380, 377);
            this.Name = "FormMain";
            this.Text = "Diviseurs";
            this.groupBox_Resultat.ResumeLayout(false);
            this.groupBox_Resultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SaisieNumerateur;
        private System.Windows.Forms.Label label_SaisieDenominateur;
        private System.Windows.Forms.Button button_Calculer;
        private System.Windows.Forms.Label label_resultat;
        private System.Windows.Forms.Label label_ResultatNumerateur;
        private System.Windows.Forms.Label label_ResultatDenominateur;
        private System.Windows.Forms.GroupBox groupBox_Resultat;
        private System.Windows.Forms.Label label_ResultSeparateur;
        private System.Windows.Forms.TextBox textBox_ResultDenominateur;
        private System.Windows.Forms.TextBox textBox_ResultNumerateur;
        private System.Windows.Forms.TextBox textBox_Numerateur;
        private System.Windows.Forms.TextBox textBox_Denominateur;
        private System.Windows.Forms.Label label_Separateur;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_PGDC;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Titre;
        private System.Windows.Forms.Label label_Credit;
    }
}

