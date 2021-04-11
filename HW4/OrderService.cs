using System;
using System.Collections.Generic;
using System.Linq;


namespace HW4
{
    class OrderService
    {
        private List<Order> _orders = new List<Order>();
        public List<Order> Orders { set; get; }
        public OrderService() { }
        public OrderService(List<Order> orders)
        {
            this._orders = orders;
            Orders = orders;
        }
        public void sort()                                                 //默认按照订单号排序
        {
            _orders.Sort((p1, p2) => p1.OrderNum - p2.OrderNum);
        }
        public void add(Order order)                                       //添加订单
        {
            _orders.Add(order);
        }
        public void sub(int id)                                           //根据订单号删除订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orders)
                {
                    i++;
                    if (order.OrderNum == id)
                    {
                        j = i;
                    }
                }
                _orders.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单删除失败，请检查输入的订单号!");
            }
        }
        public void modify(int id, Order neworder)                           //根据订单号修改订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orders)
                {
                    i++;
                    if (order.OrderNum == id)
                    {
                        j = i;
                    }
                }
                _orders[j] = neworder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单修改失败，请检查输入的订单号!");
            }
        }
        public Order getOrder(int id)                                              //按照订单号查询
        {
            var query = _orders.Where(o => o.OrderNum == id);
            Order order = (Order)query;
            return order;
        }
        public List<Order> querybyClient(String name)                              //按照客户名查询
        {
            var query = _orders.Where(o => o.Client.ClientName == name).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public void showID()                                                       //输出订单编号
        {
            foreach (Order order in _orders)
            {
                Console.Write(order.OrderNum + " ");
            }
        }
    }
}
