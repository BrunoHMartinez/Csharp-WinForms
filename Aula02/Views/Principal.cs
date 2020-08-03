using Aula02.DAL;
using Aula02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace Aula02.Views
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            RenderizarLista();
        }

        public void RenderizarLista()
        {
        List<Pedido> pedidos = PedidoDAO.ListarPedidos();

            foreach (Pedido p in pedidos)
            {
                string[] vetor =
                {
                    p.PedidoId.ToString(),
                    p.Produto,
                    p.Quantidade.ToString(),
                    p.Valor.ToString(),
                    p.Fornecedor.ToString(),
                    p.Data.ToString()
                };
                ListViewItem item = new ListViewItem(vetor);
                lstPedidos.Items.Add(item);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();

            p.Produto = Convert.ToString(txtProduto.Text);
            p.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            p.Valor = Convert.ToDouble(txtValor.Text);
            p.Fornecedor = Convert.ToString(txtFornecedor.Text);
            p.Data = Convert.ToDateTime(txtData.Text);
            PedidoDAO.Cadastrar(p);
            lstPedidos.Items.Clear();
            RenderizarLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = (" ");
            txtProduto.Text = (" ");
            txtQuantidade.Text = (" ");
            txtValor.Text = (" ");
            txtFornecedor.Text = (" ");
            txtData.Text = (" ");

        }

        private void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstPedidos.SelectedItems.Count > 0)
            {
                txtId.Text = lstPedidos.SelectedItems[0].SubItems[0].Text;
                txtProduto.Text = lstPedidos.SelectedItems[0].SubItems[1].Text;
                txtQuantidade.Text = lstPedidos.SelectedItems[0].SubItems[2].Text;
                txtValor.Text = lstPedidos.SelectedItems[0].SubItems[3].Text;
                txtFornecedor.Text = lstPedidos.SelectedItems[0].SubItems[4].Text;
                txtData.Text = lstPedidos.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos = PedidoDAO.ListarPedidos();
            int validacao = Convert.ToInt32(lstPedidos.SelectedItems[0].SubItems[0].Text);
            foreach (Pedido p in pedidos)
            {
                if (validacao == p.PedidoId)
                {
                    p.Produto = Convert.ToString(txtProduto.Text);
                    p.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                    p.Valor = Convert.ToDouble(txtValor.Text);
                    p.Fornecedor = Convert.ToString(txtFornecedor.Text);
                    p.Data = Convert.ToDateTime(txtData.Text);
                    PedidoDAO.Alterar(p);
                    lstPedidos.Items.Clear();
                    RenderizarLista();
                    MessageBox.Show("Pedido alterado!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos = PedidoDAO.ListarPedidos();

            foreach (Pedido p in pedidos)
            {
                if (lstPedidos.SelectedItems.Count > 0)
                {
                    string[] vetor =
                {
                    p.PedidoId.ToString(),
                    p.Produto,
                    p.Quantidade.ToString(),
                    p.Valor.ToString(),
                    p.Fornecedor.ToString(),
                    p.Data.ToString()
                };
                    ListViewItem item = new ListViewItem(vetor);
                    lstPedidos.Items.Remove(item);
                    PedidoDAO.Excluir(p);
                    lstPedidos.Items.Clear();
                    RenderizarLista();
                    MessageBox.Show("Pedido excluido!");
                }
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
