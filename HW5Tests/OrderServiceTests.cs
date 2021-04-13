using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace HW5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        private List<Order> _orders = new List<Order>();
        public List<Order> Orders { set; get; }
        private List<Order> _orders1 = new List<Order>();

        [TestMethod()]
        public void sortTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            OrderService orderService = new OrderService();
            _orders.Add(order2);
            _orders.Add(order1);
            _orders.Add(order3);            
            orderService.sort();

            _orders1.Add(order1);
            _orders1.Add(order2);
            _orders1.Add(order3);
            Assert.AreEqual(_orders, _orders1);

        }

        [TestMethod()]
        public void addTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);

            _orders1.Add(order2);
            _orders1.Add(order1);
            _orders1.Add(order3);
            Assert.AreEqual(_orders, _orders1);
        }

        [TestMethod()]
        public void subTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            _orders.Add(order2);
            _orders.Add(order1);
            _orders.Add(order3);

            OrderService orderService = new OrderService(_orders);
            
            orderService.sub(003);

            _orders1.Add(order2);
            _orders1.Add(order1);

            Assert.AreEqual(_orders, _orders1);
        }

        [TestMethod()]
        public void modifyTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            _orders.Add(order2);
            _orders.Add(order1);
            _orders.Add(order3);

            OrderService orderService = new OrderService(_orders);

            orderService.modify(2, order1);

            _orders1.Add(order1);
            _orders1.Add(order1);
            _orders1.Add(order3);

            Assert.AreEqual(_orders, _orders1);
        }

        [TestMethod()]
        public void getOrderTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            _orders.Add(order2);
            _orders.Add(order1);
            _orders.Add(order3);

            OrderService orderService = new OrderService(_orders);
            Order ordercc = orderService.getOrder(002);

            Assert.AreEqual(ordercc,order2);
        }

        [TestMethod()]
        public void querybyClientTest()
        {
            Goods goods1 = new Goods("goods1", 1);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
 

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };

            Order order1 = new Order(1, client1, orderItems1);

            _orders.Add(order1);

            OrderService orderService = new OrderService(_orders);
            List<Order> _orders11 = orderService.querybyClient("c1");

            Assert.AreEqual(_orders11, _orders1);
        }

        [TestMethod()]
        public void showIDTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            _orders.Add(order2);
            _orders.Add(order1);
            _orders.Add(order3);

            OrderService orderService = new OrderService(_orders);

            orderService.showID();

            string sss = "213";

            Assert.AreEqual(sss, orderService.s);

        }

        [TestMethod()]
        public void ExportTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            orderService.Export();
            _orders1.Add(order2);
            _orders1.Add(order1);
            _orders1.Add(order3);
            using (FileStream fs = new FileStream("D:/s.xml", FileMode.Open))
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                _orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            Assert.AreEqual(_orders,_orders1);

        }

        [TestMethod()]
        public void ImportTest()
        {
            Goods goods1 = new Goods("goods1", 1);                                          //测试数据
            Goods goods2 = new Goods("goods2", 2);
            Goods goods3 = new Goods("goods3", 3);
            Goods goods4 = new Goods("goods4", 4);
            Goods goods5 = new Goods("goods5", 5);

            Client client1 = new Client("c1");
            Client client2 = new Client("c2");
            Client client3 = new Client("c3");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client2, orderItems2);
            Order order3 = new Order(3, client3, orderItems3);

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            _orders=orderService.Import();
            _orders1.Add(order2);
            _orders1.Add(order1);
            _orders1.Add(order3);

            Assert.AreEqual(_orders, _orders1);
        }
    }
}