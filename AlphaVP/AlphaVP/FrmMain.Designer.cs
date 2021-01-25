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
            this.pcbVisual = new System.Windows.Forms.PictureBox();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.btnPlayBreak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de personnes :";
            // 
            // lblNbPerson
            // 
            this.lblNbPerson.AutoSize = true;
            this.lblNbPerson.Location = new System.Drawing.Point(139, 9);
            this.lblNbPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPerson.Name = "lblNbPerson";
            this.lblNbPerson.Size = new System.Drawing.Size(35, 13);
            this.lblNbPerson.TabIndex = 1;
            this.lblNbPerson.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'infecté :";
            // 
            // lblNbInfected
            // 
            this.lblNbInfected.AutoSize = true;
            this.lblNbInfected.Location = new System.Drawing.Point(139, 35);
            this.lblNbInfected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbInfected.Name = "lblNbInfected";
            this.lblNbInfected.Size = new System.Drawing.Size(35, 13);
            this.lblNbInfected.TabIndex = 3;
            this.lblNbInfected.Text = "label4";
            // 
            // lblNbDeath
            // 
            this.lblNbDeath.AutoSize = true;
            this.lblNbDeath.Location = new System.Drawing.Point(139, 61);
            this.lblNbDeath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbDeath.Name = "lblNbDeath";
            this.lblNbDeath.Size = new System.Drawing.Size(35, 13);
            this.lblNbDeath.TabIndex = 5;
            this.lblNbDeath.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de décès :";
            // 
            // pcbVisual
            // 
            this.pcbVisual.Location = new System.Drawing.Point(217, 9);
            this.pcbVisual.Name = "pcbVisual";
            this.pcbVisual.Size = new System.Drawing.Size(560, 363);
            this.pcbVisual.TabIndex = 6;
            this.pcbVisual.TabStop = false;
            this.pcbVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualPaint);
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(14, 91);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(160, 252);
            this.tbxData.TabIndex = 7;
            // 
            // btnPlayBreak
            // 
            this.btnPlayBreak.Location = new System.Drawing.Point(14, 349);
            this.btnPlayBreak.Name = "btnPlayBreak";
            this.btnPlayBreak.Size = new System.Drawing.Size(160, 23);
            this.btnPlayBreak.TabIndex = 8;
            this.btnPlayBreak.Text = "Play/Pause";
            this.btnPlayBreak.UseVisualStyleBackColor = true;
            this.btnPlayBreak.Click += new System.EventHandler(this.PlayBreak_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 384);
            this.Controls.Add(this.btnPlayBreak);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.pcbVisual);
            this.Controls.Add(this.lblNbDeath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNbInfected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNbPerson);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Alpha Virus propagation";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisual)).EndInit();
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
        private System.Windows.Forms.PictureBox pcbVisual;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.Button btnPlayBreak;
    }
}

