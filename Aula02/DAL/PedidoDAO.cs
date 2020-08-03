using Aula02.Models;
using Aula02.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula02.DAL
{
    public class PedidoDAO
    {

        private static Context ctx = new Context();

        public static List<Pedido> ListarPedidos()
        {
            return ctx.Pedidos.ToList();
        }

        public static void Cadastrar(Pedido p)
        {
            if (!ctx.Pedidos.Any(pedido => pedido.Produto == p.Produto))
            {
                ctx.Pedidos.Add(p);
                ctx.SaveChanges();
            }
            else
            {
                MessageBox.Show("Esse Produto já foi registrado!");
            }            
        }

        public static void Alterar (Pedido p)
        {
                ctx.Pedidos.Update(p);
                ctx.SaveChanges();          
        }

        public static void Excluir(Pedido p)
        {
            ctx.Pedidos.Remove(p);
            ctx.SaveChanges();
        }
    }
}
