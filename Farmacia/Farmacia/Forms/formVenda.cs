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
    public partial class formVenda : Form
    {
        public decimal valorProduto;
        public int valorDescontoFinal;
        tb_produtos_farmacia objProduto = new tb_produtos_farmacia();
        tb_clientes_farmacia clienteVenda = new tb_clientes_farmacia();
        public formVenda()
        {
            InitializeComponent();
        }

        public formVenda(tb_produtos_farmacia produtoVender)
        {
            objProduto = produtoVender;
            InitializeComponent();

            if (objProduto.fl_alergenicos == true)
            {
                lbAlergenico.Visible = true;
                lbAlergenico.Enabled = true;
                MessageBox.Show("Esse remédio possuí Alergênicos", "Alerta de alergênicos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (objProduto.fl_cronico == true)
            {
                lbDescontoCronico.Visible = true;
                cbDescontoCronico.Enabled = true;
                cbDescontoCronico.Visible = true;
            }

            txtPreco.Text = objProduto.valor_produto.ToString();
            txtProduto.Text = objProduto.tx_nome_produto;
            pbFoto.Image = auxiliar.ByteArrayToImage(objProduto.img_produto);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            nudProduto.Maximum = (int)objProduto.in_quantidade;

            valorProduto = Convert.ToDecimal(objProduto.valor_produto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCpfCliente.Text.Where(x => char.IsNumber(x)).Count() > 0)
            {
                cbOferecerRecorrente.Enabled = false;
                cbOferecerRecorrente.Visible = false;
                lbDescontoRecorrente.Visible = false;

                txtNomeCliente.Text = string.Empty;
                txtEmailCliente.Text = string.Empty;
                txtTelefoneCliente.Text = string.Empty;

                clienteDAO clientedao = new clienteDAO();

                var cpf = Convert.ToDecimal(txtCpfCliente.Text);
                clienteVenda = clientedao.pegarClientePorCpf(cpf);
         

                if (clienteVenda != null)
                {
                    if(clientedao.temCompraRecorrente(clienteVenda.id_cliente, objProduto.id_produto) && objProduto.porcentagem_desconto_recorrente > 0)
                    {
                        cbOferecerRecorrente.Enabled = true;
                        cbOferecerRecorrente.Visible = true;
                        lbDescontoRecorrente.Visible = true;
                    }
           


                    btnVender.Enabled = true;
                    txtNomeCliente.Text = clienteVenda.tx_nome;
                    txtEmailCliente.Text = clienteVenda.email;
                    txtTelefoneCliente.Text = clienteVenda.telefone;
                }
                else
                {
                    MessageBox.Show("Cpf não encontrado", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nudProduto_ValueChanged(object sender, EventArgs e)
        {

            var quantidade = Convert.ToDecimal(nudProduto.Value);
            var valorFinal = valorProduto * quantidade;
            txtPreco.Text = auxiliar.gerarDesconto(Convert.ToDecimal(objProduto.valor_produto * nudProduto.Value), valorDescontoFinal);

            //txtPreco.Text = valorFinal.ToString();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valor final:"+ txtPreco.Text +  " Deseja finalizar a venda ?", "Vender ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                produtoDAO produtodao = new produtoDAO();
                tb_produtos_vendidos_farmacia produtoVender = new tb_produtos_vendidos_farmacia();

                produtoVender.data_venda = DateTime.Now;
                produtoVender.id_cliente = clienteVenda.id_cliente;
                produtoVender.id_produto = objProduto.id_produto;
                produtoVender.in_quantidade_vendido = (int)nudProduto.Value;
                produtoVender.valor_total = Convert.ToDecimal(txtPreco.Text);

                var resultadoVenda = produtodao.insertVenda(produtoVender);

                if (resultadoVenda)
                {
                    objProduto.in_quantidade = (objProduto.in_quantidade - produtoVender.in_quantidade_vendido);
                    produtodao.atualizarProduto(objProduto);
                    MessageBox.Show("Venda efetuada com sucesso","Concluído",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();    
                }
                else
                {
                    MessageBox.Show("Erro interno, entre em contato com o suporte", "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Venda cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbOferecerRecorrente_CheckedChanged(object sender, EventArgs e)
        {
            if(cbOferecerRecorrente.Checked)
            {
                valorDescontoFinal += (int)objProduto.porcentagem_desconto_recorrente;
                txtPreco.Text = auxiliar.gerarDesconto(Convert.ToDecimal(objProduto.valor_produto * nudProduto.Value), valorDescontoFinal);
            }
            else
            {
                valorDescontoFinal -= (int)objProduto.porcentagem_desconto_recorrente;
                txtPreco.Text = auxiliar.gerarDesconto((objProduto.valor_produto * nudProduto.Value), valorDescontoFinal);

            }
        }

        private void cbDescontoCronico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDescontoCronico.Checked)
            {
                valorDescontoFinal += (int)objProduto.porcentagem_desconto_cronico;
                txtPreco.Text = auxiliar.gerarDesconto(Convert.ToDecimal(objProduto.valor_produto * nudProduto.Value), valorDescontoFinal);
            }
            else
            {
                valorDescontoFinal -= (int)objProduto.porcentagem_desconto_cronico;
                txtPreco.Text = auxiliar.gerarDesconto((objProduto.valor_produto * nudProduto.Value), valorDescontoFinal);

            }
        }
    }
}
