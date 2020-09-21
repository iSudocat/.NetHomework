using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageSystem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class OrderServiceTest
        {
            [TestMethod]
            public void AddOrder_test1()
            {
                var service = new OrderService();
                service.AddOrder(new Order("Sudocat"));
                Assert.AreEqual("Sudocat", service.OrderList[0].Customer);
            }


            [TestMethod]
            public void DelOrder_test1()
            {
                var service = new OrderService();
                service.AddOrder(new Order("Sudocat"));
                service.AddOrder(new Order("ASaltyFish"));
                service.DelOrder(service.OrderList[0].ID);
                Assert.AreEqual("ASaltyFish", service.OrderList[0].Customer);

            }

            [TestMethod]
            public void SortOrder_test1()
            {
                var service = new OrderService();
                service.AddOrder(new Order("Sudocat"));
                service.AddOrder(new Order("ASaltyFish"));
                service.AddOrder(new Order("Tim"));
                foreach (var o in service.OrderList)
                {
                    Console.WriteLine(o.ToString());
                }
                service.SortOrder("Customer");
                foreach (var o in service.OrderList)
                {
                    Console.WriteLine(o.ToString());
                }
                Assert.AreEqual("ASaltyFish", service.OrderList[0].Customer);
            }

            [TestMethod]
            public void SortOrder_test2()
            {
                var service = new OrderService();
                var o1 = new Order("Sudocat");
                var o2 = new Order("Tim");
                service.AddOrder(o1);
                service.AddOrder(o2);
                o1.AddItem("ˮ��", 3);
                o2.AddItem("ˮ��", 2);
                foreach (var o in service.OrderList)
                {
                    Console.WriteLine(o.ToString());
                }
                service.SortOrder("Price");
                foreach (var o in service.OrderList)
                {
                    Console.WriteLine(o.ToString());
                }
                Assert.AreEqual("Tim", service.OrderList[0].Customer);
            }

            [TestMethod]
            public void ModifyOrder_test1()
            {
                var service = new OrderService();
                var o = new Order("Sudocat");
                service.AddOrder(o);
                o.AddItem("ˮ��", 3);
                service.ModifyOrder(o.ID, "ˮ��", 2);
                Assert.AreEqual(19.9 * 2, service.OrderList[0].TotalPrice);
            }

            [TestMethod]
            public void Query_test1()
            {
                var service = new OrderService();
                var o = new Order("Sudocat");
                service.AddOrder(o);
                o.AddItem("ˮ��", 3);
                var re = service.Query("ID", o.ID);
                Assert.IsTrue(re.Contains("��Ʒ��ˮ�� ������3"));
            }
        }
    }
}
