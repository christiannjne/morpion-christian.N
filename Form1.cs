using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morpion_christian.N
{
    public partial class Frm_morpion : Form

    {
        string joueur1 = "x";
        string joueur2 = "0";
        int gagner = 0;
        string tourdujoueur = "x";

        string case1;
        string case2;
        string case3;
        string case4;
        string case5;
        string case6;
        string case7;
        string case8;
        String case9;

        public Frm_morpion()
        {
            InitializeComponent();
        }

        private void menu_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sousmenu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ce jeu est  créé par christian njine v1.0 /n/ Copyright ©2019 All rights reserved!!!");
        }

        private void sousmenu_regledujeu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Les joueurs cochent tour à tour une grille.Le premier qui parvient à aligner cinq de ses symboles horizontalement, verticalement ou en diagonale gagne un point.");
        }

        private void sousmenu_1vsIA_Click(object sender, EventArgs e)
        {
            gpbx_groupecase.Visible = true;
            btn_messageaccueil.Visible = false;
        }

        private void sousmenu_1vs1_Click(object sender, EventArgs e)
        {
            gpbx_groupecase.Visible = true;
            btn_messageaccueil.Visible = false;
        }


        private void gpbx_groupecase_Enter(object sender, EventArgs e)
        {
            string joueur1;
            string joueur2;
            bool gagner=true;
            var resultat;



            //joueur 1 joue
            //joueur 2 joue
            //joueur 1 joue
            //joueur 2 joue
            //joueur 1 joue
            //joueur 2 joue
            //joueur 1 joue
            //joueur 2 joue
            //joueur 1 joue

            //gagner verticale
            if (resultat = case1 + case2 + case3)
                gagner = true;
            if (resultat = case4 + case5 + case6)
                gagner = true;
            if (resultat = case7 + case8 + case9)
                gagner = true;
            //gagner horizontale
            if (resultat = case1 + case4 + case7)
                gagner = true;
            if (resultat = case2 + case5 + case8)
                gagner = true;
            if (resultat = case3 + case6 + case9)
                gagner = true;
            //gagner oblique
            if (resultat = case1 + case5 + case9)
                gagner = true;
            if (resultat = case7 + case5 + case3)
                gagner = true;

            if (gagner == true)
            {
                if (gagner = Convert.ToBoolean(joueur1))
                   
                else
                    gagner = joueur2;

                MessageBox.Show(gagner + "vous avez gagner");
            }
            






        }

        private void Btn_case_Click (Button btn_case)
        {
            if (btn_case.Text.ToString() != "")
            {
                // emplacement invalide
                tatut.text = "emplacement invalide";
            }
            //marquer le symbole
            //verifier si joueur gagner
            //verifier match null
            //change joueur
        }

        private void btn_case2_Click(object sender, EventArgs e)
        {
            hgh
        }

        private void btn_case1_Click(object sender, EventArgs e)
        {
           case1= btn_case1.Text = "x";
        }

        private void btn_case3_Click(object sender, EventArgs e)
        {

        }

        private void btn_case4_Click(object sender, EventArgs e)
        {

        }

        private void btn_case5_Click(object sender, EventArgs e)
        {

        }

        private void btn_case6_Click(object sender, EventArgs e)
        {

        }

        private void btn_case7_Click(object sender, EventArgs e)
        {

        }

        private void btn_case8_Click(object sender, EventArgs e)
        {

        }

        private void btn_case9_Click(object sender, EventArgs e)
        {

        }


    }
}
