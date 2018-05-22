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
    public partial class formPrincipal : Form
    {
        public List<tb_produtos_farmacia> listaProdutos;
        public formPrincipal()
        {

            InitializeComponent();
            montaProdutosIniciais();

        }

        public formPrincipal(int id_usuario)
        {
     

            InitializeComponent();
            cadastrarUsuarioToolStripMenuItem.Enabled = false;
            cadastrarProdutoToolStripMenuItem.Enabled = false;
            montaProdutosIniciais();

        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastrarUsuario frmCadastroUsuario = new formCadastrarUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEstoque frmEstoque = new formEstoque();
            frmEstoque.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastrarCliente frmCliente = new formCadastrarCliente();
            frmCliente.ShowDialog();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEstoque frmEstoque = new formEstoque();
            frmEstoque.ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formClientes frmClientes = new formClientes();
            frmClientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBusca.Text))
            {
                if (rbCodigo.Checked)
                {
                    if (txtBusca.Text.Where(x => char.IsNumber(x)).Count() > 0)
                    {
                        var codigoDigitado = Convert.ToInt32(txtBusca.Text);

                        produtoDAO produtodao = new produtoDAO();
                        var produtoEncontrado = produtodao.pegarProdutoPorCodigo(codigoDigitado);

                        if(produtoEncontrado != null && produtoEncontrado.in_quantidade > 0)
                        {
                            formVenda frmVenda = new formVenda(produtoEncontrado);
                            frmVenda.Show();
                        }
                        else if(produtoEncontrado.in_quantidade == 0)
                        {
                            MessageBox.Show("Produto esgotado, entre em contato com o fornecedor", "Sem estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }
                    else
                    {
                        MessageBox.Show("Digite apenas números para buscar por código", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    produtoDAO produtodao = new produtoDAO();
                    var lstProdutosFiltradosPornome = produtodao.buscarProdutosPorNome(txtBusca.Text);
                    montaProdutosIniciais(lstProdutosFiltradosPornome);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void montaProdutosIniciais(List<tb_produtos_farmacia> lstProdutos)
        {


            listaProdutos = lstProdutos;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel15.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
          

            if (lstProdutos.Count >0)
            {
                panel1.Visible = true;
                lbRemedio.Text = lstProdutos[0].tx_nome_produto;
                pbRemedioUm.Image = auxiliar.ByteArrayToImage(lstProdutos[0].img_produto);
                pbRemedioUm.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio.Text = lstProdutos[0].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 1)
            {
                panel2.Visible = true;
                lbRemedio2.Text = lstProdutos[1].tx_nome_produto;
                pbRemedioDois.Image = auxiliar.ByteArrayToImage(lstProdutos[1].img_produto);
                pbRemedioDois.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio2.Text = lstProdutos[1].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 2)
            {
                panel3.Visible = true;
                lbRemedio3.Text = lstProdutos[2].tx_nome_produto;
                pbRemedioTres.Image = auxiliar.ByteArrayToImage(lstProdutos[2].img_produto);
                pbRemedioTres.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio3.Text = lstProdutos[2].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 3)
            {
                panel4.Visible = true;
                lbRemedio4.Text = lstProdutos[3].tx_nome_produto;
                pbRemedioQuatro.Image = auxiliar.ByteArrayToImage(lstProdutos[3].img_produto);
                pbRemedioQuatro.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio4.Text = lstProdutos[3].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 4)
            {
                panel5.Visible = true;
                lbRemedio5.Text = lstProdutos[4].tx_nome_produto;
                pbRemedioCinco.Image = auxiliar.ByteArrayToImage(lstProdutos[4].img_produto);
                pbRemedioCinco.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio5.Text = lstProdutos[4].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 5)
            {
                panel6.Visible = true;
                lbRemedio6.Text = lstProdutos[5].tx_nome_produto;
                pbRemedioSeis.Image = auxiliar.ByteArrayToImage(lstProdutos[5].img_produto);
                pbRemedioSeis.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio6.Text = lstProdutos[5].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 6)
            {
                panel7.Visible = true;
                lbRemedio7.Text = lstProdutos[6].tx_nome_produto;
                pbRemedioSete.Image = auxiliar.ByteArrayToImage(lstProdutos[6].img_produto);
                pbRemedioSete.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio7.Text = lstProdutos[6].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 7)
            {
                panel8.Visible = true;
                lbRemedio8.Text = lstProdutos[7].tx_nome_produto;
                pbRemedioOito.Image = auxiliar.ByteArrayToImage(lstProdutos[7].img_produto);
                pbRemedioOito.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio8.Text = lstProdutos[7].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 8)
            {
                panel9.Visible = true;
                lbRemedio9.Text = lstProdutos[8].tx_nome_produto;
                pbRemedioNove.Image = auxiliar.ByteArrayToImage(lstProdutos[8].img_produto);
                pbRemedioNove.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio9.Text = lstProdutos[8].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 9)
            {
                panel10.Visible = true;
                lbRemedio10.Text = lstProdutos[9].tx_nome_produto;
                pbRemedioDez.Image = auxiliar.ByteArrayToImage(lstProdutos[9].img_produto);
                pbRemedioDez.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio10.Text = lstProdutos[9].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 10)
            {
                panel11.Visible = true;
                lbRemedio11.Text = lstProdutos[10].tx_nome_produto;
                pbRemedioOnze.Image = auxiliar.ByteArrayToImage(lstProdutos[10].img_produto);
                pbRemedioOnze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio11.Text = lstProdutos[10].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 11)
            {
                panel12.Visible = true;
                lbRemedio12.Text = lstProdutos[11].tx_nome_produto;
                pbRemedioDoze.Image = auxiliar.ByteArrayToImage(lstProdutos[11].img_produto);
                pbRemedioDoze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio12.Text = lstProdutos[11].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 12)
            {
                panel13.Visible = true;
                lbRemedio13.Text = lstProdutos[12].tx_nome_produto;
                pbRemedioTreze.Image = auxiliar.ByteArrayToImage(lstProdutos[12].img_produto);
                pbRemedioTreze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio13.Text = lstProdutos[12].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 13)
            {
                panel14.Visible = true;
                lbRemedio14.Text = lstProdutos[13].tx_nome_produto;
                pbRemedioQuatorze.Image = auxiliar.ByteArrayToImage(lstProdutos[13].img_produto);
                pbRemedioQuatorze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio14.Text = lstProdutos[13].in_quantidade.ToString();
            }


            if (lstProdutos.Count > 14)
            {
                panel15.Visible = true;
                lbRemedio15.Text = lstProdutos[14].tx_nome_produto;
                pbRemedioQuinze.Image = auxiliar.ByteArrayToImage(lstProdutos[14].img_produto);
                pbRemedioQuinze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio15.Text = lstProdutos[14].in_quantidade.ToString();
            }
        }

        public void montaProdutosIniciais()
        {

            produtoDAO novoProdutoDAO = new produtoDAO();
            var lstProdutos = novoProdutoDAO.pegarProdutosMaisVendidos();


            listaProdutos = lstProdutos;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel15.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;


            if (lstProdutos.Count > 0)
            {
                panel1.Visible = true;
                lbRemedio.Text = lstProdutos[0].tx_nome_produto;
                pbRemedioUm.Image = auxiliar.ByteArrayToImage(lstProdutos[0].img_produto);
                pbRemedioUm.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio.Text = lstProdutos[0].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 1)
            {
                panel2.Visible = true;
                lbRemedio2.Text = lstProdutos[1].tx_nome_produto;
                pbRemedioDois.Image = auxiliar.ByteArrayToImage(lstProdutos[1].img_produto);
                pbRemedioDois.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio2.Text = lstProdutos[1].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 2)
            {
                panel3.Visible = true;
                lbRemedio3.Text = lstProdutos[2].tx_nome_produto;
                pbRemedioTres.Image = auxiliar.ByteArrayToImage(lstProdutos[2].img_produto);
                pbRemedioTres.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio3.Text = lstProdutos[2].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 3)
            {
                panel4.Visible = true;
                lbRemedio4.Text = lstProdutos[3].tx_nome_produto;
                pbRemedioQuatro.Image = auxiliar.ByteArrayToImage(lstProdutos[3].img_produto);
                pbRemedioQuatro.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio4.Text = lstProdutos[3].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 4)
            {
                panel5.Visible = true;
                lbRemedio5.Text = lstProdutos[4].tx_nome_produto;
                pbRemedioCinco.Image = auxiliar.ByteArrayToImage(lstProdutos[4].img_produto);
                pbRemedioCinco.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio5.Text = lstProdutos[4].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 5)
            {
                panel6.Visible = true;
                lbRemedio6.Text = lstProdutos[5].tx_nome_produto;
                pbRemedioSeis.Image = auxiliar.ByteArrayToImage(lstProdutos[5].img_produto);
                pbRemedioSeis.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio6.Text = lstProdutos[5].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 6)
            {
                panel7.Visible = true;
                lbRemedio7.Text = lstProdutos[6].tx_nome_produto;
                pbRemedioSete.Image = auxiliar.ByteArrayToImage(lstProdutos[6].img_produto);
                pbRemedioSete.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio7.Text = lstProdutos[6].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 7)
            {
                panel8.Visible = true;
                lbRemedio8.Text = lstProdutos[7].tx_nome_produto;
                pbRemedioOito.Image = auxiliar.ByteArrayToImage(lstProdutos[7].img_produto);
                pbRemedioOito.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio8.Text = lstProdutos[7].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 8)
            {
                panel9.Visible = true;
                lbRemedio9.Text = lstProdutos[8].tx_nome_produto;
                pbRemedioNove.Image = auxiliar.ByteArrayToImage(lstProdutos[8].img_produto);
                pbRemedioNove.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio9.Text = lstProdutos[8].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 9)
            {
                panel10.Visible = true;
                lbRemedio10.Text = lstProdutos[9].tx_nome_produto;
                pbRemedioDez.Image = auxiliar.ByteArrayToImage(lstProdutos[9].img_produto);
                pbRemedioDez.SizeMode = PictureBoxSizeMode.StretchImage;
                txtQuantidadeRemedio10.Text = lstProdutos[9].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 10)
            {
                panel11.Visible = true;
                lbRemedio11.Text = lstProdutos[10].tx_nome_produto;
                pbRemedioOnze.Image = auxiliar.ByteArrayToImage(lstProdutos[10].img_produto);
                pbRemedioOnze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio11.Text = lstProdutos[10].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 11)
            {
                panel12.Visible = true;
                lbRemedio12.Text = lstProdutos[11].tx_nome_produto;
                pbRemedioDoze.Image = auxiliar.ByteArrayToImage(lstProdutos[11].img_produto);
                pbRemedioDoze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio12.Text = lstProdutos[11].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 12)
            {
                panel13.Visible = true;
                lbRemedio13.Text = lstProdutos[12].tx_nome_produto;
                pbRemedioTreze.Image = auxiliar.ByteArrayToImage(lstProdutos[12].img_produto);
                pbRemedioTreze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio13.Text = lstProdutos[12].in_quantidade.ToString();
            }

            if (lstProdutos.Count > 13)
            {
                panel14.Visible = true;
                lbRemedio14.Text = lstProdutos[13].tx_nome_produto;
                pbRemedioQuatorze.Image = auxiliar.ByteArrayToImage(lstProdutos[13].img_produto);
                pbRemedioQuatorze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio14.Text = lstProdutos[13].in_quantidade.ToString();
            }


            if (lstProdutos.Count > 14)
            {
                panel15.Visible = true;
                lbRemedio15.Text = lstProdutos[14].tx_nome_produto;
                pbRemedioQuinze.Image = auxiliar.ByteArrayToImage(lstProdutos[14].img_produto);
                pbRemedioQuinze.SizeMode = PictureBoxSizeMode.StretchImage;
                txQuantidadeRemedio15.Text = lstProdutos[14].in_quantidade.ToString();
            }
        }

        private void plProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLstProdutos frmLstProdutos = new formLstProdutos();
            frmLstProdutos.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[0].id_produto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbRemedioQuinze_Click(object sender, EventArgs e)
        {

        }

        private void pegarProdutoPorcodigo(int codigo)
        {
            var codigoDigitado = codigo;

            produtoDAO produtodao = new produtoDAO();
            var produtoEncontrado = produtodao.pegarProdutoPorCodigo(codigoDigitado);

            if (produtoEncontrado != null && produtoEncontrado.in_quantidade > 0)
            {
                formVenda frmVenda = new formVenda(produtoEncontrado);
                frmVenda.Show();
            }
            else if (produtoEncontrado.in_quantidade == 0)
            {
                MessageBox.Show("Produto esgotado, entre em contato com o fornecedor", "Sem estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnVender2_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[1].id_produto);

        }

        private void btnVender3_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[2].id_produto);

        }

        private void btnVender4_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[3].id_produto);

        }

        private void btnVender5_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[4].id_produto);

        }

        private void btnVender6_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[5].id_produto);

        }

        private void btnVender7_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[6].id_produto);

        }

        private void btnVender8_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[7].id_produto);

        }

        private void btnVender9_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[8].id_produto);

        }

        private void btnVender10_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[9].id_produto);

        }

        private void btnVender11_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[10].id_produto);

        }

        private void btnVender12_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[11].id_produto);

        }

        private void btnVender13_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[12].id_produto);

        }

        private void btnVender14_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[13].id_produto);

        }

        private void btnVender15_Click(object sender, EventArgs e)
        {
            pegarProdutoPorcodigo(listaProdutos[14].id_produto);
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            montaProdutosIniciais();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            montaProdutosIniciais();
        }
    }
}
