namespace Farmacia.Forms
{
    partial class formClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtViewClientes = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarRemedio = new System.Windows.Forms.Button();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.btnCadastrarNovoCliente = new System.Windows.Forms.Button();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite código ou cpf para buscar";
            // 
            // dtViewClientes
            // 
            this.dtViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.NomeProduto,
            this.Quantidade,
            this.Email,
            this.Telefone,
            this.endereco,
            this.Cep,
            this.Bairro,
            this.Cidade});
            this.dtViewClientes.Location = new System.Drawing.Point(12, 111);
            this.dtViewClientes.Name = "dtViewClientes";
            this.dtViewClientes.Size = new System.Drawing.Size(953, 172);
            this.dtViewClientes.TabIndex = 8;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoProduto.HeaderText = "Codigo";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Width = 50;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Width = 160;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Cpf";
            this.Quantidade.Name = "Quantidade";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            // 
            // Cep
            // 
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // btnBuscarRemedio
            // 
            this.btnBuscarRemedio.Location = new System.Drawing.Point(606, 47);
            this.btnBuscarRemedio.Name = "btnBuscarRemedio";
            this.btnBuscarRemedio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRemedio.TabIndex = 7;
            this.btnBuscarRemedio.Text = "Buscar";
            this.btnBuscarRemedio.UseVisualStyleBackColor = true;
            this.btnBuscarRemedio.Click += new System.EventHandler(this.btnBuscarRemedio_Click);
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(341, 50);
            this.txtBuscaCliente.MaxLength = 11;
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(246, 20);
            this.txtBuscaCliente.TabIndex = 6;
            // 
            // btnCadastrarNovoCliente
            // 
            this.btnCadastrarNovoCliente.Location = new System.Drawing.Point(822, 331);
            this.btnCadastrarNovoCliente.Name = "btnCadastrarNovoCliente";
            this.btnCadastrarNovoCliente.Size = new System.Drawing.Size(128, 37);
            this.btnCadastrarNovoCliente.TabIndex = 5;
            this.btnCadastrarNovoCliente.Text = "Cadastrar novo cliente";
            this.btnCadastrarNovoCliente.UseVisualStyleBackColor = true;
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Checked = true;
            this.rbCpf.Location = new System.Drawing.Point(414, 77);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(41, 17);
            this.rbCpf.TabIndex = 10;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "Cpf";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(502, 77);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 11;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1021, 389);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.rbCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtViewClientes);
            this.Controls.Add(this.btnBuscarRemedio);
            this.Controls.Add(this.txtBuscaCliente);
            this.Controls.Add(this.btnCadastrarNovoCliente);
            this.MaximizeBox = false;
            this.Name = "formClientes";
            this.Text = "formClientes";
            this.VisibleChanged += new System.EventHandler(this.formClientes_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtViewClientes;
        private System.Windows.Forms.Button btnBuscarRemedio;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Button btnCadastrarNovoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}