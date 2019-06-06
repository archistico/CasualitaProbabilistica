namespace CasualitàProbabilistica
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRis = new System.Windows.Forms.TextBox();
            this.btCrea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upLunghezza = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upLunghezza)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRis
            // 
            this.tbRis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRis.Location = new System.Drawing.Point(12, 124);
            this.tbRis.Multiline = true;
            this.tbRis.Name = "tbRis";
            this.tbRis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRis.Size = new System.Drawing.Size(268, 409);
            this.tbRis.TabIndex = 0;
            // 
            // btCrea
            // 
            this.btCrea.Location = new System.Drawing.Point(12, 71);
            this.btCrea.Name = "btCrea";
            this.btCrea.Size = new System.Drawing.Size(268, 47);
            this.btCrea.TabIndex = 2;
            this.btCrea.Text = "Crea nuova parola";
            this.btCrea.UseVisualStyleBackColor = true;
            this.btCrea.Click += new System.EventHandler(this.btCrea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserisci la lunghezza della parola";
            // 
            // upLunghezza
            // 
            this.upLunghezza.Location = new System.Drawing.Point(183, 45);
            this.upLunghezza.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.upLunghezza.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upLunghezza.Name = "upLunghezza";
            this.upLunghezza.Size = new System.Drawing.Size(97, 20);
            this.upLunghezza.TabIndex = 4;
            this.upLunghezza.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUOVE PAROLE";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upLunghezza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCrea);
            this.Controls.Add(this.tbRis);
            this.Name = "frmMain";
            this.Text = "Casualità Probabilistica";
            ((System.ComponentModel.ISupportInitialize)(this.upLunghezza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRis;
        private System.Windows.Forms.Button btCrea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upLunghezza;
        private System.Windows.Forms.Label label2;
    }
}

