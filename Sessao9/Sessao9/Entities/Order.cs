using Sessao9.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao9.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment=moment;
            Status=status;
            Client=client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach(OrderItem item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.Name+" ("+ Client.BirthDate.ToString("dd/MM/yyyy")+") - "+ Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.Append(item.Product.Name+ ", Quantity: "+item.Quantity);
                sb.AppendLine(", Subtotal: "+ item.Price.ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total price:  $"+ Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();


        }

    }
}
