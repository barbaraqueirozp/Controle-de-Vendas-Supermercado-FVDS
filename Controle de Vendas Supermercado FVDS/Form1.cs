namespace Controle_de_Vendas_Supermercado_FVDS
{
    public partial class Form1 : Form
    {
        double totalVenda = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string produto;
            int quantidade;
            double preco;
            double subtotal;

            produto = txtProduto.Text;
            quantidade = Convert.ToInt32(txtQuantidade.Text);
            preco = Convert.ToDouble(txtPreco.Text);

            subtotal = quantidade * preco;

            txtSubtotal.Text = subtotal.ToString("F2");

            lstProduto.Items.Add(produto);
            lstQuantidade.Items.Add(quantidade);
            lstPreco.Items.Add(preco.ToString("F2"));
            lstSubtotal.Items.Add(subtotal.ToString("F2"));

            totalVenda = totalVenda + subtotal;

            txtTotal.Text = totalVenda.ToString("F2");

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();

            txtProduto.Focus();
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Total da venda: R$ " + totalVenda.ToString("F2"),
       "Venda finalizada",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
   );

            lstProduto.Items.Clear();
            lstQuantidade.Items.Clear();
            lstPreco.Items.Clear();
            lstSubtotal.Items.Clear();

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();

            totalVenda = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstProduto.Items.Clear();
            lstQuantidade.Items.Clear();
            lstPreco.Items.Clear();
            lstSubtotal.Items.Clear();

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();

            totalVenda = 0;

            txtProduto.Focus();
        }
    }
}
