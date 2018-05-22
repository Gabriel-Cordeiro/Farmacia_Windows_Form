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
    public partial class formCadastrarCliente : Form
    {
        public formCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && nmCpf.Value != 0 && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtTelefone.Text))
            {
                tb_clientes_farmacia novoCliente = new tb_clientes_farmacia
                {
                    tx_nome = txtNome.Text,
                    in_cpf = Convert.ToDecimal(nmCpf.Value),
                    endereco = txtEndereco.Text ?? string.Empty,
                    bairro = txtBairro.Text ?? string.Empty,
                    cidade = txtCidade.Text ?? string.Empty,
                    cep = txtCep.Text ?? string.Empty,
                    email = txtEmail.Text ?? string.Empty,
                    telefone = txtTelefone.Text
                };

                clienteDAO clientedao = new clienteDAO();
                if (clientedao.inserirCliente(novoCliente))
                {
                    MessageBox.Show("Cliente inserido com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente, tente novamente ou contate o suporte do sistema", "Erro interno", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Nome, cpf, telefone e e-mail não podem estar em branco", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
