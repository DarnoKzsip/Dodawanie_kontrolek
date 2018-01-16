using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamiczne_dodawanie_kontrolek
{
    public partial class Glowne : Form
    {
        int lw;
        int lk;
       

        public Glowne()
        {
            InitializeComponent();
           
        }

        private void BTN_Dodajkontolke_Click(object sender, EventArgs e)
        {
            lw = Convert.ToInt32(TB_LiczbaWierzcholkow.Text);
            lk = Convert.ToInt32(TB_LiczbaWierzcholkow.Text);

            int marg_pion = 40;
            int marg_poz = 95;

            for (int w = 0; w < lw + 1; w++) {
                marg_poz = 105;
                marg_pion = marg_pion + 30;
                for (int k = 0; k < lk + 1; k++) {
                    marg_poz = marg_poz + 30;
                    string nazwa = "TB_Wartosc" + w + k;  
                    TextBox nowy = new TextBox();
                    nowy.Name = nazwa;
                    nowy.Text = " ";
                    nowy.Location = new System.Drawing.Point(marg_pion, marg_poz);
                    nowy.Size = new System.Drawing.Size(20, 20);
                    this.Controls.Add(nowy);


                }
                



            }

            TextBox textbox1 = new TextBox();
            textbox1.Text = "Nowy Text Box!!";
            textbox1.Location = new System.Drawing.Point(20, 10);
            this.Controls.Add(textbox1);
            
        }
    }
}
