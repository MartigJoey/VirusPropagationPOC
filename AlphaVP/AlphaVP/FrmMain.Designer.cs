namespace AlphaVP
{
    partial class FrmMain
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
            this.time = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblNbPerson = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNbInfected = new System.Windows.Forms.Label();
            this.lblNbDeath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de personnes :";
            // 
            // lblNbPerson
            // 
            this.lblNbPerson.AutoSize = true;
            this.lblNbPerson.Location = new System.Drawing.Point(313, 107);
            this.lblNbPerson.Name = "lblNbPerson";
            this.lblNbPerson.Size = new System.Drawing.Size(70, 25);
            this.lblNbPerson.TabIndex = 1;
            this.lblNbPerson.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'infecté :";
            // 
            // lblNbInfected
            // 
            this.lblNbInfected.AutoSize = true;
            this.lblNbInfected.Location = new System.Drawing.Point(313, 158);
            this.lblNbInfected.Name = "lblNbInfected";
            this.lblNbInfected.Size = new System.Drawing.Size(70, 25);
            this.lblNbInfected.TabIndex = 3;
            this.lblNbInfected.Text = "label4";
            // 
            // lblNbDeath
            // 
            this.lblNbDeath.AutoSize = true;
            this.lblNbDeath.Location = new System.Drawing.Point(313, 208);
            this.lblNbDeath.Name = "lblNbDeath";
            this.lblNbDeath.Size = new System.Drawing.Size(70, 25);
            this.lblNbDeath.TabIndex = 5;
            this.lblNbDeath.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de décès :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.lblNbDeath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNbInfected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNbPerson);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Alpha Virus propagation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNbPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNbInfected;
        private System.Windows.Forms.Label lblNbDeath;
        private System.Windows.Forms.Label label4;
    }
}

