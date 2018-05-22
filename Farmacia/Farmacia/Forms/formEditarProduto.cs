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
    public partial class formEditarProduto : Form
    {
        private byte[] imagem_produto;
        public formEditarProduto()
        {
            InitializeComponent();
        }

        public formEditarProduto(tb_produtos_farmacia objProduto)
        {
            InitializeComponent();

            txtCodigo.Text = objProduto.id_produto.ToString();
            txtNomeProduto.Text = objProduto.tx_nome_produto;
            in_preco_produto.Value = objProduto.valor_produto ?? 0;
            in_desconto_cronico.Value = objProduto.porcentagem_desconto_cronico ?? 0;
            cb_alergenico.Checked = objProduto.fl_alergenicos == true ? true : false;
            cb_cronico.Checked = objProduto.fl_cronico == true ? true : false;
            in_quantidade_produto.Value = objProduto.in_quantidade ?? 0;
            picFotoProduto.Image = auxiliar.ByteArrayToImage(objProduto.img_produto);

            imagem_produto = objProduto.img_produto;
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

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomeProduto.Text) && in_preco_produto.Value > 0 && in_quantidade_produto.Value > 0)
            {
                tb_produtos_farmacia novoProduto = new tb_produtos_farmacia
                {
                    id_produto =Convert.ToInt32(txtCodigo.Text),
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

                if (produtodao.atualizarProduto(novoProduto))
                {
                    MessageBox.Show("Produto Atualizado com sucesso", "Produto atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar produtos", "Erro ao inserir cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nome do produto, preço e quantidade não podem estar em branco ou zerados", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
