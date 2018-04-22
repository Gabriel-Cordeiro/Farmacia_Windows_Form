using Farmacia.BancoDeDados;
using Farmacia.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Forms
{
    public partial class formCadastrarUsuario : Form
    {
        public formCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text) && cbTipoUsuario.SelectedItem != null)
            {
                var tipoPerfil = cbTipoUsuario.SelectedItem.ToString() == "Estoquista"? 3 
                               : cbTipoUsuario.SelectedItem.ToString() == "Atendente" ? 2 : 1;

                tb_usuario novoUsuario = new tb_usuario
                {

                    tx_nome = txtNome.Text.ToString(),
                    tx_login = txtLogin.Text.ToString(),
                    tx_cpf = txtCpf.Text.ToString(),
                    tx_senha = txtSenha.Text.ToString(),
                    id_usuario_perfil = tipoPerfil

                };

                usuarioDAO usuarioDao = new usuarioDAO();

                var cadastroEfetuado = usuarioDao.inserirUsuario(novoUsuario);

                if (cadastroEfetuado)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nome, login, senha e tipo de usuário não podem estar em branco", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
