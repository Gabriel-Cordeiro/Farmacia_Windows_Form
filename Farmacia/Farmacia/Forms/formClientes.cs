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
    public partial class formClientes : Form
    {
        clienteDAO clientedao = new clienteDAO();
        tb_clientes_farmacia clienteEscolhido = new tb_clientes_farmacia();
        List<tb_clientes_farmacia> lstCliente = new List<tb_clientes_farmacia>();
        public formClientes()
        {
            InitializeComponent();
            //montaClientes();

        }
        private void montaClientes()
        {
            lstCliente = clientedao.pegarTodosClientes();

            for (int i = 0; i < lstCliente.Count; i++)
            {
                dtViewClientes.Rows.Add(1);
                dtViewClientes.Rows[i].Cells[0].Value = lstCliente[i].id_cliente.ToString();
                dtViewClientes.Rows[i].Cells[1].Value = lstCliente[i].tx_nome.ToString();
                dtViewClientes.Rows[i].Cells[2].Value = lstCliente[i].in_cpf.ToString();
                dtViewClientes.Rows[i].Cells[3].Value = lstCliente[i].email.ToString();
                dtViewClientes.Rows[i].Cells[4].Value = lstCliente[i].telefone.ToString();
                dtViewClientes.Rows[i].Cells[5].Value = lstCliente[i].endereco?.ToString() ?? string.Empty;
                dtViewClientes.Rows[i].Cells[6].Value = lstCliente[i].cep.ToString() ?? string.Empty;
                dtViewClientes.Rows[i].Cells[7].Value = lstCliente[i].bairro.ToString() ?? string.Empty;
                dtViewClientes.Rows[i].Cells[8].Value = lstCliente[i].cidade.ToString() ?? string.Empty;


            }
        }

        private void btnBuscarRemedio_Click(object sender, EventArgs e)
        {
            if(rbCpf.Checked)
            {
                var cpf = Convert.ToDecimal(txtBuscaCliente.Text.Replace("-", "").Replace(".", ""));
                clienteEscolhido = lstCliente.Where(x => x.in_cpf == cpf).FirstOrDefault();
                if(clienteEscolhido != null)
                {
                    this.Visible = false;
                    formEditarCliente frmEditarCliente = new formEditarCliente(clienteEscolhido);
                    frmEditarCliente.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rbCodigo.Checked)
            {
                var codigo_cliente = Convert.ToInt32(txtBuscaCliente.Text);
                clienteEscolhido = lstCliente.Where(x => x.id_cliente == codigo_cliente).FirstOrDefault();

                if (clienteEscolhido != null)
                {
                    this.Visible = false;
                    formEditarCliente frmEditarCliente = new formEditarCliente(clienteEscolhido);
                    frmEditarCliente.ShowDialog();
                    this.Visible = true;

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void formClientes_VisibleChanged(object sender, EventArgs e)
        {
            dtViewClientes.Rows.Clear();
            montaClientes();
        }
    }
}
