namespace Sistema
{
    partial class frm_venda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fimVenda = new System.Windows.Forms.Button();
            this.btn_fimPedido = new System.Windows.Forms.Button();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_novoItem = new System.Windows.Forms.Button();
            this.CB_produto = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DG_vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(12, 26);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(39, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(6, 32);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 100);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(6, 139);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(6, 66);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(347, 432);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(61, 13);
            valorPagoLabel.TabIndex = 10;
            valorPagoLabel.Text = "Valor Total:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(347, 366);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 12;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(347, 399);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 14;
            descontoLabel.Text = "Desconto:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Sistema.DAL.Venda);
            // 
            // CB_cliente
            // 
            this.CB_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_cliente.DataSource = this.pessoasBindingSource;
            this.CB_cliente.DisplayMember = "Descricao";
            this.CB_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cliente.FormattingEnabled = true;
            this.CB_cliente.Location = new System.Drawing.Point(77, 23);
            this.CB_cliente.Name = "CB_cliente";
            this.CB_cliente.Size = new System.Drawing.Size(200, 21);
            this.CB_cliente.TabIndex = 2;
            this.CB_cliente.ValueMember = "Codigo";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Sistema.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_fimVenda);
            this.groupBox1.Controls.Add(this.btn_fimPedido);
            this.groupBox1.Controls.Add(this.txt_valorTotal);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(this.btn_novoItem);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.CB_produto);
            this.groupBox1.Controls.Add(this.DG_vendas);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 523);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(233, 427);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(91, 23);
            this.btn_imprimir.TabIndex = 20;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_fimVenda
            // 
            this.btn_fimVenda.Enabled = false;
            this.btn_fimVenda.Location = new System.Drawing.Point(233, 394);
            this.btn_fimVenda.Name = "btn_fimVenda";
            this.btn_fimVenda.Size = new System.Drawing.Size(91, 23);
            this.btn_fimVenda.TabIndex = 19;
            this.btn_fimVenda.Text = "Finalizar Venda";
            this.btn_fimVenda.UseVisualStyleBackColor = true;
            this.btn_fimVenda.Click += new System.EventHandler(this.btn_fimVenda_Click);
            // 
            // btn_fimPedido
            // 
            this.btn_fimPedido.Location = new System.Drawing.Point(233, 361);
            this.btn_fimPedido.Name = "btn_fimPedido";
            this.btn_fimPedido.Size = new System.Drawing.Size(91, 23);
            this.btn_fimPedido.TabIndex = 18;
            this.btn_fimPedido.Text = "Finalizar Pedido";
            this.btn_fimPedido.UseVisualStyleBackColor = true;
            this.btn_fimPedido.Click += new System.EventHandler(this.btn_fimPedido_Click);
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valorTotal.Location = new System.Drawing.Point(424, 429);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.ReadOnly = true;
            this.txt_valorTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_valorTotal.TabIndex = 17;
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(424, 396);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 16;
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_valor.Location = new System.Drawing.Point(424, 363);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 15;
            // 
            // btn_novoItem
            // 
            this.btn_novoItem.Location = new System.Drawing.Point(265, 134);
            this.btn_novoItem.Name = "btn_novoItem";
            this.btn_novoItem.Size = new System.Drawing.Size(75, 23);
            this.btn_novoItem.TabIndex = 5;
            this.btn_novoItem.Text = "Novo Item";
            this.btn_novoItem.UseVisualStyleBackColor = true;
            this.btn_novoItem.Click += new System.EventHandler(this.btn_novoItem_Click);
            // 
            // CB_produto
            // 
            this.CB_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.CB_produto.DataSource = this.produtoBindingSource;
            this.CB_produto.DisplayMember = "Descricao";
            this.CB_produto.FormattingEnabled = true;
            this.CB_produto.Location = new System.Drawing.Point(95, 63);
            this.CB_produto.Name = "CB_produto";
            this.CB_produto.Size = new System.Drawing.Size(142, 21);
            this.CB_produto.TabIndex = 9;
            this.CB_produto.ValueMember = "Codigo";
            this.CB_produto.SelectedIndexChanged += new System.EventHandler(this.CB_produto_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Sistema.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema.DAL.Produto);
            // 
            // DG_vendas
            // 
            this.DG_vendas.AllowUserToAddRows = false;
            this.DG_vendas.AllowUserToDeleteRows = false;
            this.DG_vendas.AutoGenerateColumns = false;
            this.DG_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DG_vendas.DataSource = this.itensVendaBindingSource;
            this.DG_vendas.Location = new System.Drawing.Point(6, 196);
            this.DG_vendas.Name = "DG_vendas";
            this.DG_vendas.ReadOnly = true;
            this.DG_vendas.Size = new System.Drawing.Size(518, 144);
            this.DG_vendas.TabIndex = 8;
            this.DG_vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // Column1
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(95, 136);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(142, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(95, 97);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(142, 20);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_codigo.Location = new System.Drawing.Point(95, 29);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(142, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.CB_cliente);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.ComboBox CB_produto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView DG_vendas;
        private System.Windows.Forms.Button btn_novoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fimVenda;
        private System.Windows.Forms.Button btn_fimPedido;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor;
    }
}