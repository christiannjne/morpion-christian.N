using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using morpion_christian.N;

namespace morpion_christian.N
{
    public partial class prenomjoeur : Form
    {

        public prenomjoeur()
        {
            InitializeComponent();
        }

        public void btn_ok_Click(object sender, EventArgs e)
        {
            //porter prenom sur le form1
            donneepubliqueprenom.prenomjoeurx = tbx_prenomx.Text;
            donneepubliqueprenom.prenomjoeur0 = tbx_prenom0.Text;


            if (tbx_prenomx.Text != "" && tbx_prenom0.Text == "" || tbx_prenom0.Text != "" && tbx_prenomx.Text == "")
            {
                MessageBox.Show("vous devez entrer le prenom de l'autre joueur");
                this.Owner.Show();
            }

            if (tbx_prenomx.Text == "" && tbx_prenom0.Text == "")
            {
                MessageBox.Show("vous devez entrer vos prenoms pour joueur");
                this.Owner.Show();
            }

            if (tbx_prenomx.Text !="" && tbx_prenom0.Text !="")
            {
                this.Close();
                this.Owner.Show();
            }
        }
    }
}
