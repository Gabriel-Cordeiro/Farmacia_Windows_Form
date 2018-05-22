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
    public partial class formLstProdutos : Form
    {

        produtoDAO produtodao = new produtoDAO();
        List<tb_produtos_farmacia> lstProdutos = new List<tb_produtos_farmacia>();
        public formLstProdutos()
        {
            InitializeComponent();

            lstProdutos = produtodao.pegarTodosProdutos();

            for (int i = 0; i < lstProdutos.Count; i++)
            {
                dtViewProdutos.Rows.Add(1);
                dtViewProdutos.Rows[i].Cells[0].Value = lstProdutos[i].id_produto.ToString();
                dtViewProdutos.Rows[i].Cells[1].Value = lstProdutos[i].tx_nome_produto.ToString();
                dtViewProdutos.Rows[i].Cells[2].Value = lstProdutos[i].in_quantidade.ToString();
                dtViewProdutos.Rows[i].Cells[3].Value = lstProdutos[i].fl_cronico == true ? "Sim" : "Não";
                dtViewProdutos.Rows[i].Cells[4].Value = lstProdutos[i].fl_alergenicos == true ? "Sim" : "Não";
                dtViewProdutos.Rows[i].Cells[5].Value = lstProdutos[i].valor_produto.ToString();
                dtViewProdutos.Rows[i].Cells[6].Value = lstProdutos[i].porcentagem_desconto_recorrente.ToString() + "%";
                dtViewProdutos.Rows[i].Cells[7].Value = lstProdutos[i].porcentagem_desconto_cronico.ToString() + "%";

            }

        }

        private void formLstProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
