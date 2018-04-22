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
    public partial class formEditarCliente : Form
    {
        public formEditarCliente()
        {
            InitializeComponent();
        }

        public formEditarCliente(tb_clientes objCliente)
        {
            InitializeComponent();

            txtNome.Text = objCliente.tx_nome;
            txtEmail.Text = objCliente.email;
            txtBairro.Text = objCliente.bairro ?? string.Empty;
            txtCep.Text = objCliente.cep ?? string.Empty;
            txtTelefone.Text = objCliente.telefone ?? string.Empty;
            txtCodigoCliente.Text = objCliente.id_cliente.ToString();
            txtCidade.Text = objCliente.cidade ?? string.Empty;
            nmCpf.Value = objCliente.in_cpf ?? 0;
            txtEndereco.Text = objCliente.endereco ?? string.Empty;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && nmCpf.Value != 0 && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtTelefone.Text))
            {
                tb_clientes novoCliente = new tb_clientes
                {
                    id_cliente = Convert.ToInt32(txtCodigoCliente.Text),
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
                if (clientedao.atualizarCliente(novoCliente))
                {
                    MessageBox.Show("Cliente atualizado com sucesso", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar cliente, tente novamente ou contate o suporte do sistema", "Erro interno", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Nome, cpf, telefone e e-mail não podem estar em branco", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void formEditarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
          
       
        }
    }
}
