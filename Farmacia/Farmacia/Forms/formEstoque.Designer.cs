namespace Farmacia.Forms
{
    partial class formEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarNovoProduto = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnBuscarRemedio = new System.Windows.Forms.Button();
            this.dtViewProdutos = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarNovoProduto
            // 
            this.btnCadastrarNovoProduto.Location = new System.Drawing.Point(436, 311);
            this.btnCadastrarNovoProduto.Name = "btnCadastrarNovoProduto";
            this.btnCadastrarNovoProduto.Size = new System.Drawing.Size(128, 37);
            this.btnCadastrarNovoProduto.TabIndex = 0;
            this.btnCadastrarNovoProduto.Text = "Cadastrar novo produto";
            this.btnCadastrarNovoProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoProduto.Click += new System.EventHandler(this.btnCadastrarNovoProduto_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(183, 41);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(246, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // btnBuscarRemedio
            // 
            this.btnBuscarRemedio.Location = new System.Drawing.Point(448, 38);
            this.btnBuscarRemedio.Name = "btnBuscarRemedio";
            this.btnBuscarRemedio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRemedio.TabIndex = 2;
            this.btnBuscarRemedio.Text = "Buscar";
            this.btnBuscarRemedio.UseVisualStyleBackColor = true;
            this.btnBuscarRemedio.Click += new System.EventHandler(this.btnBuscarRemedio_Click);
            // 
            // dtViewProdutos
            // 
            this.dtViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.NomeProduto,
            this.Quantidade});
            this.dtViewProdutos.Location = new System.Drawing.Point(102, 88);
            this.dtViewProdutos.Name = "dtViewProdutos";
            this.dtViewProdutos.Size = new System.Drawing.Size(440, 172);
            this.dtViewProdutos.TabIndex = 3;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoProduto.HeaderText = "Codigo Produto";
            this.CodigoProduto.Name = "CodigoProduto";
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite código do produto para busca-lo";
            // 
            // formEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(606, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtViewProdutos);
            this.Controls.Add(this.btnBuscarRemedio);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.btnCadastrarNovoProduto);
            this.MaximizeBox = false;
            this.Name = "formEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.formEstoque_Load);
            this.VisibleChanged += new System.EventHandler(this.formEstoque_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarNovoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnBuscarRemedio;
        private System.Windows.Forms.DataGridView dtViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label label1;
    }
}