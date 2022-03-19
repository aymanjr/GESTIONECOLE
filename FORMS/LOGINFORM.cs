﻿using GESTIONECOLE.FORMS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE
{
    public partial class LOGINFORM : Form
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BtnLogin.Enabled = false;

        }

        private void loginbtn_Click(object sender, EventArgs e)    //LOGIN BUTTON 
        {



        }

        private void checklogin()    //CHECK THE USER LOGIN 
        {
            r.connecter();

            r.command = new SqlCommand("select * from USERS where username = '" + Txtusername.Text + "' AND pass = '" + txtpass.Text + "'", r.connection);
            r.reader = r.command.ExecuteReader();

            if (r.reader.Read())
            {
                MessageBox.Show("WELCOME BACK ");

                   THEMAINFORM ee = new THEMAINFORM();
                   this.Hide();
                   ee.ShowDialog();
                   this.Close();


            }
            else
            {
                if (MessageBox.Show("VOTRE INFORMATION ET INCORRECT ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtpass.ResetText();
                }
            }

            r.deconnecter();

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)   //cancel button
        {
            if (MessageBox.Show("TU VEUX QUITER L'APPLICATION ? ", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (DialogResult == DialogResult.No)
            {
                txtpass.ResetText();
            }
        }

        private void label3_Click(object sender, EventArgs e)  //quiter button 
        {
            if (MessageBox.Show("TU VEUX QUITER L'APPLICATION ? ", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (DialogResult == DialogResult.No)
            {
                txtpass.ResetText();
            }
        }

        private void txtlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();

            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void loginbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void cancelbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtusername.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("ENTRER VOTRE USERNAME ET PASSWORD", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txtusername.ResetText();
                txtpass.ResetText();


            }
            else
            {
                checklogin();

            }
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(Txtusername.Text))
            {
                BtnLogin.Enabled = true;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
