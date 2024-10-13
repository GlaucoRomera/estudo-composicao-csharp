using System.Text;
using System.Collections;
using System.Globalization;
using Orders.Entities.Enums;

namespace Orders.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        private List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {

                sum += item.SubTotal();

            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString("C", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
