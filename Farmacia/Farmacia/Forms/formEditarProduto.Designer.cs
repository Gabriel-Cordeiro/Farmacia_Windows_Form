namespace Farmacia.Forms
{
    partial class formEditarProduto
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
            this.in_desconto_cronico = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.in_porcentagem_produto = new System.Windows.Forms.NumericUpDown();
            this.in_preco_produto = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.cb_cronico = new System.Windows.Forms.CheckBox();
            this.cb_alergenico = new System.Windows.Forms.CheckBox();
            this.picFotoProduto = new System.Windows.Forms.PictureBox();
            this.in_quantidade_produto = new System.Windows.Forms.NumericUpDown();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.buscarPastaFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.in_desconto_cronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_porcentagem_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_preco_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_quantidade_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // in_desconto_cronico
            // 
            this.in_desconto_cronico.Location = new System.Drawing.Point(204, 129);
            this.in_desconto_cronico.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.in_desconto_cronico.Name = "in_desconto_cronico";
            this.in_desconto_cronico.Size = new System.Drawing.Size(100, 20);
            this.in_desconto_cronico.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Porcentagem desconto cronico";
            // 
            // in_porcentagem_produto
            // 
            this.in_porcentagem_produto.Location = new System.Drawing.Point(204, 101);
            this.in_porcentagem_produto.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.in_porcentagem_produto.Name = "in_porcentagem_produto";
            this.in_porcentagem_produto.Size = new System.Drawing.Size(100, 20);
            this.in_porcentagem_produto.TabIndex = 15;
            // 
            // in_preco_produto
            // 
            this.in_preco_produto.DecimalPlaces = 2;
            this.in_preco_produto.Location = new System.Drawing.Point(204, 74);
            this.in_preco_produto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.in_preco_produto.Name = "in_preco_produto";
            this.in_preco_produto.Size = new System.Drawing.Size(100, 20);
            this.in_preco_produto.TabIndex = 14;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(415, 176);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFoto.TabIndex = 23;
            this.btnBuscarFoto.Text = "Buscar Foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // cb_cronico
            // 
            this.cb_cronico.AutoSize = true;
            this.cb_cronico.Location = new System.Drawing.Point(203, 218);
            this.cb_cronico.Name = "cb_cronico";
            this.cb_cronico.Size = new System.Drawing.Size(62, 17);
            this.cb_cronico.TabIndex = 21;
            this.cb_cronico.Text = "Crônico";
            this.cb_cronico.UseVisualStyleBackColor = true;
            // 
            // cb_alergenico
            // 
            this.cb_alergenico.AutoSize = true;
            this.cb_alergenico.Location = new System.Drawing.Point(203, 194);
            this.cb_alergenico.Name = "cb_alergenico";
            this.cb_alergenico.Size = new System.Drawing.Size(76, 17);
            this.cb_alergenico.TabIndex = 19;
            this.cb_alergenico.Text = "Alergênico";
            this.cb_alergenico.UseVisualStyleBackColor = true;
            // 
            // picFotoProduto
            // 
            this.picFotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoProduto.Location = new System.Drawing.Point(365, 30);
            this.picFotoProduto.Name = "picFotoProduto";
            this.picFotoProduto.Size = new System.Drawing.Size(162, 124);
            this.picFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProduto.TabIndex = 26;
            this.picFotoProduto.TabStop = false;
            // 
            // in_quantidade_produto
            // 
            this.in_quantidade_produto.Location = new System.Drawing.Point(205, 167);
            this.in_quantidade_produto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.in_quantidade_produto.Name = "in_quantidade_produto";
            this.in_quantidade_produto.Size = new System.Drawing.Size(100, 20);
            this.in_quantidade_produto.TabIndex = 17;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(242, 278);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProduto.TabIndex = 25;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Porcentagem desconto recorrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(204, 48);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Codigo Produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(204, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // buscarPastaFoto
            // 
            this.buscarPastaFoto.FileName = "buscarPastaFoto";
            // 
            // formEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(550, 370);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.in_desconto_cronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.in_porcentagem_produto);
            this.Controls.Add(this.in_preco_produto);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.cb_cronico);
            this.Controls.Add(this.cb_alergenico);
            this.Controls.Add(this.picFotoProduto);
            this.Controls.Add(this.in_quantidade_produto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.MaximizeBox = false;
            this.Name = "formEditarProduto";
            this.Text = "formEditarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.in_desconto_cronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_porcentagem_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_preco_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_quantidade_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown in_desconto_cronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown in_porcentagem_produto;
        private System.Windows.Forms.NumericUpDown in_preco_produto;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.CheckBox cb_cronico;
        private System.Windows.Forms.CheckBox cb_alergenico;
        private System.Windows.Forms.PictureBox picFotoProduto;
        private System.Windows.Forms.NumericUpDown in_quantidade_produto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.OpenFileDialog buscarPastaFoto;
    }
}