using Farmacia.Classes;
using Farmacia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string loginInserido = txtLogin.Text.ToString();
                string senhaInserido = txtPassword.Text.ToString();

                var usuarioDao = new usuarioDAO();

                var usuariologin = usuarioDao.verificarLogin(loginInserido, senhaInserido);

                if(usuariologin != null)
                {
                   
                    switch (usuariologin.id_usuario_perfil)
                    {
                        case 1: //gerente
                            this.Hide();
                            formPrincipal formPrincipal = new formPrincipal();
                            formPrincipal.Closed += (s, args) => this.Close();
                            formPrincipal.Show();
                            break;

                        case 2: //atendente
                            this.Hide();
                            formPrincipal frmPrincipal = new formPrincipal((int)usuariologin.id_usuario_perfil);
                            frmPrincipal.Closed += (s, args) => this.Close();
                            frmPrincipal.Show();
                            break;

                        case 3: //estoquista
                            this.Hide();
                            formEstoque frmEstoque = new formEstoque();
                            frmEstoque.Closed += (s, args) => this.Close();
                            frmEstoque.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Dados de login inválidos");
                }
            }
            else
            {
                MessageBox.Show("Login e/ou senha em branco", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
