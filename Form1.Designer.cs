namespace dynamiczne_dodawanie_kontrolek
{
    partial class Glowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Dodajkontolke = new System.Windows.Forms.Button();
            this.TB_LiczbaWierzcholkow = new System.Windows.Forms.TextBox();
            this.Lbl_liczbaWierszy = new System.Windows.Forms.Label();
            this.LBL_Nr = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Dodajkontolke
            // 
            this.BTN_Dodajkontolke.Location = new System.Drawing.Point(302, 434);
            this.BTN_Dodajkontolke.Name = "BTN_Dodajkontolke";
            this.BTN_Dodajkontolke.Size = new System.Drawing.Size(204, 66);
            this.BTN_Dodajkontolke.TabIndex = 0;
            this.BTN_Dodajkontolke.Text = "Dodaj textbox";
            this.BTN_Dodajkontolke.UseVisualStyleBackColor = true;
            this.BTN_Dodajkontolke.Click += new System.EventHandler(this.BTN_Dodajkontolke_Click);
            // 
            // TB_LiczbaWierzcholkow
            // 
            this.TB_LiczbaWierzcholkow.Location = new System.Drawing.Point(37, 39);
            this.TB_LiczbaWierzcholkow.Name = "TB_LiczbaWierzcholkow";
            this.TB_LiczbaWierzcholkow.Size = new System.Drawing.Size(107, 20);
            this.TB_LiczbaWierzcholkow.TabIndex = 1;
            // 
            // Lbl_liczbaWierszy
            // 
            this.Lbl_liczbaWierszy.AutoSize = true;
            this.Lbl_liczbaWierszy.Location = new System.Drawing.Point(37, 13);
            this.Lbl_liczbaWierszy.Name = "Lbl_liczbaWierszy";
            this.Lbl_liczbaWierszy.Size = new System.Drawing.Size(107, 13);
            this.Lbl_liczbaWierszy.TabIndex = 2;
            this.Lbl_liczbaWierszy.Text = "Liczba wierzchołków";
            // 
            // LBL_Nr
            // 
            this.LBL_Nr.AutoSize = true;
            this.LBL_Nr.Location = new System.Drawing.Point(40, 95);
            this.LBL_Nr.Name = "LBL_Nr";
            this.LBL_Nr.Size = new System.Drawing.Size(23, 13);
            this.LBL_Nr.TabIndex = 3;
            this.LBL_Nr.Text = "NR";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 524);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBL_Nr);
            this.Controls.Add(this.Lbl_liczbaWierszy);
            this.Controls.Add(this.TB_LiczbaWierzcholkow);
            this.Controls.Add(this.BTN_Dodajkontolke);
            this.Name = "Glowne";
            this.Text = "Glowne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Dodajkontolke;
        private System.Windows.Forms.TextBox TB_LiczbaWierzcholkow;
        private System.Windows.Forms.Label Lbl_liczbaWierszy;
        private System.Windows.Forms.Label LBL_Nr;
        private System.Windows.Forms.TextBox textBox2;
    }
}

