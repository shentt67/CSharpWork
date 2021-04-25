using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form2 : Form
    {

        public Order order = new Order();
        public OrderItem item = new OrderItem();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Order order, OrderItem item)
        {
            InitializeComponent();
            orderIDTextBox.DataBindings.Add("Text", order, "OrderId");
            customerTextBox.DataBindings.Add("Text", order, "Customer");
            indexTextBox.DataBindings.Add("Text", item, "index");
            GoodsNameTextBox.DataBindings.Add("Text", item, "GoodsName");
            PriceTextBox.DataBindings.Add("Text", item, "Price");
            QuantityTextBox.DataBindings.Add("Text", item, "Quantity");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Order order1 = new Order(order.OrderId, order.Customer, new List<OrderItem> { item });

            //如果包含id相同的订单，则对该订单里面的item进行更新,否则直接添加order
            if (form1.os.Orders.Contains(order1))
            {
                Order order2 = form1.os.GetOrder(order.OrderId);

                //如果包含货物名相同的订单项，则对该订单项进行修改，若不包含该订单项，则直接添加该订单项
                if (order2.Items.Contains(item))
                {
                    OrderItem item2 = order2.GetItem(item.Index);
                    order2.RemoveItem(item2);
                    order2.Items.Add(item);
                }
                else
                {
                    order2.Items.Add(item);
                }
            }
            else
            {
                form1.os.AddOrder(order1);
            }

            form1.orderBindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
