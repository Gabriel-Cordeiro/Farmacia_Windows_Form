namespace Farmacia.Forms
{
    partial class formLstProdutos
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
            this.dtViewProdutos = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crônico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergênicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto_Recorrente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto_Cronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtViewProdutos
            // 
            this.dtViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.NomeProduto,
            this.Quantidade,
            this.Crônico,
            this.Alergênicos,
            this.Preço,
            this.Desconto_Recorrente,
            this.Desconto_Cronico});
            this.dtViewProdutos.Location = new System.Drawing.Point(32, 26);
            this.dtViewProdutos.Name = "dtViewProdutos";
            this.dtViewProdutos.Size = new System.Drawing.Size(787, 360);
            this.dtViewProdutos.TabIndex = 4;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoProduto.HeaderText = "Codigo Produto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Width = 60;
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
            // Crônico
            // 
            this.Crônico.HeaderText = "Crônico";
            this.Crônico.Name = "Crônico";
            this.Crônico.Width = 60;
            // 
            // Alergênicos
            // 
            this.Alergênicos.HeaderText = "Alergênicos";
            this.Alergênicos.Name = "Alergênicos";
            this.Alergênicos.Width = 70;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.Width = 60;
            // 
            // Desconto_Recorrente
            // 
            this.Desconto_Recorrente.HeaderText = "Recorrente";
            this.Desconto_Recorrente.Name = "Desconto_Recorrente";
            // 
            // Desconto_Cronico
            // 
            this.Desconto_Cronico.HeaderText = "Desconto Crônico";
            this.Desconto_Cronico.Name = "Desconto_Cronico";
            // 
            // formLstProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(893, 421);
            this.Controls.Add(this.dtViewProdutos);
            this.MaximizeBox = false;
            this.Name = "formLstProdutos";
            this.Text = "formLstProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crônico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergênicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto_Recorrente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto_Cronico;
    }
}