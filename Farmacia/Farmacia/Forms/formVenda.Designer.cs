namespace Farmacia.Forms
{
    partial class formVenda
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
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.plinformacoesCliente = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.cbRecorrente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOferecerRecorrente = new System.Windows.Forms.CheckBox();
            this.lbDescontoRecorrente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDescontoCronico = new System.Windows.Forms.Label();
            this.cbDescontoCronico = new System.Windows.Forms.CheckBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbAlergenico = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudProduto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.plinformacoesCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(119, 17);
            this.txtCpfCliente.MaxLength = 11;
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(162, 20);
            this.txtCpfCliente.TabIndex = 0;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(53, 20);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(60, 13);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.Text = "Cpf cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(137, 38);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(162, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // plinformacoesCliente
            // 
            this.plinformacoesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plinformacoesCliente.Controls.Add(this.flowLayoutPanel1);
            this.plinformacoesCliente.Controls.Add(this.label4);
            this.plinformacoesCliente.Controls.Add(this.txtTelefoneCliente);
            this.plinformacoesCliente.Controls.Add(this.label3);
            this.plinformacoesCliente.Controls.Add(this.txtEmailCliente);
            this.plinformacoesCliente.Controls.Add(this.cbRecorrente);
            this.plinformacoesCliente.Controls.Add(this.label1);
            this.plinformacoesCliente.Controls.Add(this.txtNomeCliente);
            this.plinformacoesCliente.Controls.Add(this.label2);
            this.plinformacoesCliente.Location = new System.Drawing.Point(9, 88);
            this.plinformacoesCliente.Name = "plinformacoesCliente";
            this.plinformacoesCliente.Size = new System.Drawing.Size(377, 198);
            this.plinformacoesCliente.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 294);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dados Cliente";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Enabled = false;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(137, 103);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(162, 20);
            this.txtTelefoneCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone Cliente:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Enabled = false;
            this.txtEmailCliente.Location = new System.Drawing.Point(137, 73);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(162, 20);
            this.txtEmailCliente.TabIndex = 5;
            // 
            // cbRecorrente
            // 
            this.cbRecorrente.AutoSize = true;
            this.cbRecorrente.Enabled = false;
            this.cbRecorrente.Location = new System.Drawing.Point(254, 170);
            this.cbRecorrente.Name = "cbRecorrente";
            this.cbRecorrente.Size = new System.Drawing.Size(118, 17);
            this.cbRecorrente.TabIndex = 4;
            this.cbRecorrente.Text = "Compra Recorrente";
            this.cbRecorrente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email Cliente:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbOferecerRecorrente);
            this.panel1.Controls.Add(this.lbDescontoRecorrente);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbDescontoCronico);
            this.panel1.Controls.Add(this.cbDescontoCronico);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.lbPreco);
            this.panel1.Controls.Add(this.lbAlergenico);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudProduto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(457, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 310);
            this.panel1.TabIndex = 6;
            // 
            // cbOferecerRecorrente
            // 
            this.cbOferecerRecorrente.AutoSize = true;
            this.cbOferecerRecorrente.Enabled = false;
            this.cbOferecerRecorrente.Location = new System.Drawing.Point(184, 173);
            this.cbOferecerRecorrente.Name = "cbOferecerRecorrente";
            this.cbOferecerRecorrente.Size = new System.Drawing.Size(43, 17);
            this.cbOferecerRecorrente.TabIndex = 16;
            this.cbOferecerRecorrente.Text = "Sim";
            this.cbOferecerRecorrente.UseVisualStyleBackColor = true;
            this.cbOferecerRecorrente.Visible = false;
            this.cbOferecerRecorrente.CheckedChanged += new System.EventHandler(this.cbOferecerRecorrente_CheckedChanged);
            // 
            // lbDescontoRecorrente
            // 
            this.lbDescontoRecorrente.AutoSize = true;
            this.lbDescontoRecorrente.Location = new System.Drawing.Point(34, 173);
            this.lbDescontoRecorrente.Name = "lbDescontoRecorrente";
            this.lbDescontoRecorrente.Size = new System.Drawing.Size(146, 13);
            this.lbDescontoRecorrente.TabIndex = 15;
            this.lbDescontoRecorrente.Text = "Oferecer desconto recorrente";
            this.lbDescontoRecorrente.Visible = false;
            this.lbDescontoRecorrente.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dados Produto";
            // 
            // lbDescontoCronico
            // 
            this.lbDescontoCronico.AutoSize = true;
            this.lbDescontoCronico.Location = new System.Drawing.Point(34, 153);
            this.lbDescontoCronico.Name = "lbDescontoCronico";
            this.lbDescontoCronico.Size = new System.Drawing.Size(133, 13);
            this.lbDescontoCronico.TabIndex = 11;
            this.lbDescontoCronico.Text = "Oferecer desconto crônico";
            this.lbDescontoCronico.Visible = false;
            this.lbDescontoCronico.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbDescontoCronico
            // 
            this.cbDescontoCronico.AutoSize = true;
            this.cbDescontoCronico.Enabled = false;
            this.cbDescontoCronico.Location = new System.Drawing.Point(184, 153);
            this.cbDescontoCronico.Name = "cbDescontoCronico";
            this.cbDescontoCronico.Size = new System.Drawing.Size(43, 17);
            this.cbDescontoCronico.TabIndex = 10;
            this.cbDescontoCronico.Text = "Sim";
            this.cbDescontoCronico.UseVisualStyleBackColor = true;
            this.cbDescontoCronico.Visible = false;
            this.cbDescontoCronico.CheckedChanged += new System.EventHandler(this.cbDescontoCronico_CheckedChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(105, 64);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(38, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(37, 64);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 6;
            this.lbPreco.Text = "Preço:";
            // 
            // lbAlergenico
            // 
            this.lbAlergenico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAlergenico.Enabled = false;
            this.lbAlergenico.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlergenico.ForeColor = System.Drawing.Color.Red;
            this.lbAlergenico.Location = new System.Drawing.Point(262, 142);
            this.lbAlergenico.Name = "lbAlergenico";
            this.lbAlergenico.Size = new System.Drawing.Size(138, 63);
            this.lbAlergenico.TabIndex = 5;
            this.lbAlergenico.Text = "Remédio possuí alergênicos";
            this.lbAlergenico.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantidade:";
            // 
            // nudProduto
            // 
            this.nudProduto.Location = new System.Drawing.Point(105, 102);
            this.nudProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProduto.Name = "nudProduto";
            this.nudProduto.Size = new System.Drawing.Size(38, 20);
            this.nudProduto.TabIndex = 3;
            this.nudProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProduto.ValueChanged += new System.EventHandler(this.nudProduto_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(105, 20);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // pbFoto
            // 
            this.pbFoto.Enabled = false;
            this.pbFoto.Location = new System.Drawing.Point(262, 14);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(137, 87);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbCliente);
            this.panel2.Controls.Add(this.txtCpfCliente);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.plinformacoesCliente);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 310);
            this.panel2.TabIndex = 7;
            // 
            // btnVender
            // 
            this.btnVender.Enabled = false;
            this.btnVender.Location = new System.Drawing.Point(772, 342);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(120, 23);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Confirmar venda";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // formVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(901, 368);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "formVenda";
            this.Text = "formVenda";
            this.plinformacoesCliente.ResumeLayout(false);
            this.plinformacoesCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel plinformacoesCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRecorrente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbAlergenico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lbDescontoCronico;
        private System.Windows.Forms.CheckBox cbDescontoCronico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbOferecerRecorrente;
        private System.Windows.Forms.Label lbDescontoRecorrente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}