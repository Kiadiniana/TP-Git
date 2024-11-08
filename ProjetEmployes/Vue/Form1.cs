﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;
using Connecte.Controleur;
using Connecte.Modele;


namespace Connecte
{
    public partial class Form1 : Form
    {

        Mgr monManager;

        List<Employe> lEmp = new List<Employe>();

      
        
        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lEmp = monManager.chargementEmpBD();

        
        affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxEmploye.DataSource = null;
                listBoxEmploye.DataSource = lEmp;
                listBoxEmploye.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            }


        





        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Récuperer l'indice de l'employé selectionné dans la listBox
                /* int i = listBoxEmploye.SelectedIndex;
                 * 
                 * Récupérer l'employé selectionné à partir de la collection lEmp
                 * Employe emp = lEmp[i];
                 */

                // Récupérer directement l'employé selectionné

                Employe emp = (Employe)listBoxEmploye.SelectedItem;

                emp.Login = tbLogin.Text;

                monManager.updateEmploye(emp);

                lEmp = monManager.chargementEmpBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Récuperer l'indice de l'employé selectionné dans la listBox
                /* int i = listBoxEmploye.SelectedIndex;
                 * 
                 * Récupérer l'employé selectionné à partir de la collection lEmp
                 * Employe emp = lEmp[i];
                 */

                // Récupérer directement l'employé selectionné

                Employe emp = (Employe)listBoxEmploye.SelectedItem;



                monManager.deleteEmploye(emp);

                lEmp = monManager.chargementEmpBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            // A compléter

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // à compléter
            try
            {
                // Récuperer l'indice de l'employé selectionné dans la listBox
                /* int i = listBoxEmploye.SelectedIndex;
                 * 
                 * Récupérer l'employé selectionné à partir de la collection lEmp
                 * Employe emp = lEmp[i];
                 */

                // Récupérer directement l'employé selectionné

                Employe emp = new Employe(Convert.ToInt16(tId.Text),"","",tbLogin.Text,0);



                monManager.insertEmploye(emp);

                lEmp = monManager.chargementEmpBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


         
        }



    }


}

           
            
            
        
            
           
        
    

