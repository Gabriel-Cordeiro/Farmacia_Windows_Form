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
    public partial class formEstoque : Form
    {
        produtoDAO produtodao = new produtoDAO();
        tb_produtos produtoEscolhido = new tb_produtos();
        List<tb_produtos> lstProdutos = new List<tb_produtos>();
        public formEstoque()
        {
            InitializeComponent();
            MontaProdutos();
        }

        private void btnCadastrarNovoProduto_Click(object sender, EventArgs e)
        {
            Visible = false;
            formNovoProduto frmNovoProduto = new formNovoProduto();
            frmNovoProduto.ShowDialog();
            Visible = true;
        }

        private void btnBuscarRemedio_Click(object sender, EventArgs e)
        {
            var produtoEscolhido = lstProdutos.Where(x => x.id_produto == Convert.ToInt32(txtCodigoProduto.Text)).FirstOrDefault();

            if (produtoEscolhido != null)
            {
                this.Visible = false;
                formEditarProduto frmEditarProduto = new formEditarProduto(produtoEscolhido);
                frmEditarProduto.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Código não encontrado, por favor verificar o número digitado", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void formEstoque_Load(object sender, EventArgs e)
        {

        }

        private void formEstoque_VisibleChanged(object sender, EventArgs e)
        {
            MontaProdutos();
        }

        public void MontaProdutos()
        {
            dtViewProdutos.Rows.Clear();
            lstProdutos = produtodao.pegarTodosProdutos();

            for (int i = 0; i < lstProdutos.Count; i++)
            {
                dtViewProdutos.Rows.Add(1);
                dtViewProdutos.Rows[i].Cells[0].Value = lstProdutos[i].id_produto.ToString();
                dtViewProdutos.Rows[i].Cells[1].Value = lstProdutos[i].tx_nome_produto.ToString();
                dtViewProdutos.Rows[i].Cells[2].Value = lstProdutos[i].in_quantidade.ToString();

            }
        }
    }
}
