using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace Sistema
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.Size = new Size(574, 105);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;

            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get { return (Venda)this.vendaBindingSource.Current; }
        }

        public ItensVenda ItemCorrente
        {
            get { return (ItensVenda)this.itensVendaBindingSource.Current; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(574, 645);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();
            CB_cliente.Enabled = false;
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void btn_novoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            DG_vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DG_vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void CB_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_produto.SelectedItem != null)
            {
                var pro = (Produto)CB_produto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach(DataGridViewRow dg in DG_vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subTotal = v1 * v2;
                dg.Cells[4].Value = subTotal;
                total = total + subTotal;
            }

            this.VendaCorrente.Valor = total;
        }

        private void btn_fimPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btn_novoItem.Enabled = false;
                CB_produto.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                btn_fimPedido.Enabled = false;
                btn_fimVenda.Enabled = true;
                txt_codigo.Enabled = false;
            }
        }

        private void btn_fimVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            btn_fimVenda.Enabled = false;
            btn_imprimir.Enabled = true;
        }
    }
}
