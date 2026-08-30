namespace Controle_de_Vendas_Supermercado_FVDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProduto = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            txtSubtotal = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            lstProduto = new ListBox();
            lstQuantidade = new ListBox();
            lstPreco = new ListBox();
            lstSubtotal = new ListBox();
            btnRemover = new Button();
            btnFecharVenda = new Button();
            label9 = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 38);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 38);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Preço Unitário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Sub Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 194);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 194);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 194);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 6;
            label7.Text = "Preço Unitário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 194);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 7;
            label8.Text = "Sub Total";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(49, 78);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(125, 27);
            txtProduto.TabIndex = 8;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(239, 78);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 9;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(422, 78);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 10;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(642, 78);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 11;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(49, 134);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(250, 33);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar produto na lista";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(582, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar Venda";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstProduto
            // 
            lstProduto.FormattingEnabled = true;
            lstProduto.Location = new Point(49, 230);
            lstProduto.Name = "lstProduto";
            lstProduto.Size = new Size(150, 84);
            lstProduto.TabIndex = 14;
            // 
            // lstQuantidade
            // 
            lstQuantidade.FormattingEnabled = true;
            lstQuantidade.Location = new Point(239, 230);
            lstQuantidade.Name = "lstQuantidade";
            lstQuantidade.Size = new Size(150, 84);
            lstQuantidade.TabIndex = 15;
            // 
            // lstPreco
            // 
            lstPreco.FormattingEnabled = true;
            lstPreco.Location = new Point(422, 230);
            lstPreco.Name = "lstPreco";
            lstPreco.Size = new Size(150, 84);
            lstPreco.TabIndex = 16;
            // 
            // lstSubtotal
            // 
            lstSubtotal.FormattingEnabled = true;
            lstSubtotal.Location = new Point(617, 230);
            lstSubtotal.Name = "lstSubtotal";
            lstSubtotal.Size = new Size(150, 84);
            lstSubtotal.TabIndex = 17;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Location = new Point(243, 342);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(329, 29);
            btnRemover.TabIndex = 18;
            btnRemover.Text = "Remover um produto da lista de compras";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnFecharVenda
            // 
            btnFecharVenda.Location = new Point(49, 391);
            btnFecharVenda.Name = "btnFecharVenda";
            btnFecharVenda.Size = new Size(150, 29);
            btnFecharVenda.TabIndex = 19;
            btnFecharVenda.Text = "Fechar Venda";
            btnFecharVenda.UseVisualStyleBackColor = true;
            btnFecharVenda.Click += btnFecharVenda_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 399);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 20;
            label9.Text = "Total a pagar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(642, 396);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(label9);
            Controls.Add(btnFecharVenda);
            Controls.Add(btnRemover);
            Controls.Add(lstSubtotal);
            Controls.Add(lstPreco);
            Controls.Add(lstQuantidade);
            Controls.Add(lstProduto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtSubtotal);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtProduto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Caixa de Supermercado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProduto;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtSubtotal;
        private Button btnAdicionar;
        private Button btnCancelar;
        private ListBox lstProduto;
        private ListBox lstQuantidade;
        private ListBox lstPreco;
        private ListBox lstSubtotal;
        private Button btnRemover;
        private Button btnFecharVenda;
        private Label label9;
        private TextBox txtTotal;
    }
}
