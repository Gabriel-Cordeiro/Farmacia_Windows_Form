using Farmacia.BancoDeDados;
using Farmacia.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Forms
{
    public partial class formNovoProduto : Form
    {
        private byte[] imagem_produto;
        public formNovoProduto()
        {
            InitializeComponent();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            DialogResult result = buscarPastaFoto.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = buscarPastaFoto.FileName;
                imagem_produto = File.ReadAllBytes(file);
                picFotoProduto.Image = Image.FromFile(file);
                picFotoProduto.SizeMode = PictureBoxSizeMode.StretchImage;

            }
           
        }

        private void buscarPastaFoto_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNomeProduto.Text) && in_preco_produto.Value > 0 && in_quantidade_produto.Value > 0)
            {
                tb_produtos novoProduto = new tb_produtos
                {
                    tx_nome_produto = txtNomeProduto.Text,
                    img_produto = imagem_produto ?? null,
                    fl_cronico = cb_cronico.Checked,
                    fl_alergenicos = cb_alergenico.Checked,
                    in_quantidade = Convert.ToInt32(in_quantidade_produto.Value),
                    valor_produto = Convert.ToDecimal(in_preco_produto.Value),
                    porcentagem_desconto_recorrente = Convert.ToInt32(in_porcentagem_produto.Value),
                    porcentagem_desconto_cronico = Convert.ToInt32(in_desconto_cronico.Value)

                };

                novoProduto.fl_cronico = novoProduto.porcentagem_desconto_cronico > 0 ? true : novoProduto.fl_cronico;

                produtoDAO produtodao = new produtoDAO();

                if(produtodao.inserirProduto(novoProduto))
                {
                    MessageBox.Show("Produto cadastrado com sucesso", "Produto Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produtos", "Erro ao inserir cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nome do produto, preço e quantidade não podem estar em branco ou zerados", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formNovoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
