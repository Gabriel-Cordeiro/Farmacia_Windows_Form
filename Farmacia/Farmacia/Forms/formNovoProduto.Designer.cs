namespace Farmacia.Forms
{
    partial class formNovoProduto
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
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.in_quantidade_produto = new System.Windows.Forms.NumericUpDown();
            this.picFotoProduto = new System.Windows.Forms.PictureBox();
            this.cb_alergenico = new System.Windows.Forms.CheckBox();
            this.cb_cronico = new System.Windows.Forms.CheckBox();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.buscarPastaFoto = new System.Windows.Forms.OpenFileDialog();
            this.in_preco_produto = new System.Windows.Forms.NumericUpDown();
            this.in_porcentagem_produto = new System.Windows.Forms.NumericUpDown();
            this.in_desconto_cronico = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.in_quantidade_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_preco_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_porcentagem_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_desconto_cronico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(229, 35);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcentagem desconto recorrente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(230, 285);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // in_quantidade_produto
            // 
            this.in_quantidade_produto.Location = new System.Drawing.Point(230, 154);
            this.in_quantidade_produto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.in_quantidade_produto.Name = "in_quantidade_produto";
            this.in_quantidade_produto.Size = new System.Drawing.Size(100, 20);
            this.in_quantidade_produto.TabIndex = 4;
            // 
            // picFotoProduto
            // 
            this.picFotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoProduto.Location = new System.Drawing.Point(379, 34);
            this.picFotoProduto.Name = "picFotoProduto";
            this.picFotoProduto.Size = new System.Drawing.Size(162, 124);
            this.picFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProduto.TabIndex = 10;
            this.picFotoProduto.TabStop = false;
            // 
            // cb_alergenico
            // 
            this.cb_alergenico.AutoSize = true;
            this.cb_alergenico.Location = new System.Drawing.Point(228, 181);
            this.cb_alergenico.Name = "cb_alergenico";
            this.cb_alergenico.Size = new System.Drawing.Size(76, 17);
            this.cb_alergenico.TabIndex = 5;
            this.cb_alergenico.Text = "Alergênico";
            this.cb_alergenico.UseVisualStyleBackColor = true;
            // 
            // cb_cronico
            // 
            this.cb_cronico.AutoSize = true;
            this.cb_cronico.Location = new System.Drawing.Point(228, 205);
            this.cb_cronico.Name = "cb_cronico";
            this.cb_cronico.Size = new System.Drawing.Size(62, 17);
            this.cb_cronico.TabIndex = 6;
            this.cb_cronico.Text = "Crônico";
            this.cb_cronico.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(429, 180);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFoto.TabIndex = 7;
            this.btnBuscarFoto.Text = "Buscar Foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // buscarPastaFoto
            // 
            this.buscarPastaFoto.FileName = "buscarPastaFoto";
            // 
            // in_preco_produto
            // 
            this.in_preco_produto.DecimalPlaces = 2;
            this.in_preco_produto.Location = new System.Drawing.Point(229, 61);
            this.in_preco_produto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.in_preco_produto.Name = "in_preco_produto";
            this.in_preco_produto.Size = new System.Drawing.Size(100, 20);
            this.in_preco_produto.TabIndex = 2;
            // 
            // in_porcentagem_produto
            // 
            this.in_porcentagem_produto.Location = new System.Drawing.Point(229, 88);
            this.in_porcentagem_produto.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.in_porcentagem_produto.Name = "in_porcentagem_produto";
            this.in_porcentagem_produto.Size = new System.Drawing.Size(100, 20);
            this.in_porcentagem_produto.TabIndex = 3;
            // 
            // in_desconto_cronico
            // 
            this.in_desconto_cronico.Location = new System.Drawing.Point(229, 116);
            this.in_desconto_cronico.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.in_desconto_cronico.Name = "in_desconto_cronico";
            this.in_desconto_cronico.Size = new System.Drawing.Size(100, 20);
            this.in_desconto_cronico.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porcentagem desconto cronico";
            // 
            // formNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.in_desconto_cronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.in_porcentagem_produto);
            this.Controls.Add(this.in_preco_produto);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.cb_cronico);
            this.Controls.Add(this.cb_alergenico);
            this.Controls.Add(this.picFotoProduto);
            this.Controls.Add(this.in_quantidade_produto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.MaximizeBox = false;
            this.Name = "formNovoProduto";
            this.Text = "formNovoProduto";
            this.Load += new System.EventHandler(this.formNovoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.in_quantidade_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_preco_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_porcentagem_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_desconto_cronico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown in_quantidade_produto;
        private System.Windows.Forms.PictureBox picFotoProduto;
        private System.Windows.Forms.CheckBox cb_alergenico;
        private System.Windows.Forms.CheckBox cb_cronico;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.OpenFileDialog buscarPastaFoto;
        private System.Windows.Forms.NumericUpDown in_preco_produto;
        private System.Windows.Forms.NumericUpDown in_porcentagem_produto;
        private System.Windows.Forms.NumericUpDown in_desconto_cronico;
        private System.Windows.Forms.Label label5;
    }
}