using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreVendors.Models;
using System.Collections.Generic;
using System;

namespace StoreVendors.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {
        public void Dispose()
        {
        Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test", "test", "test", "test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
		[TestMethod]
        public void GetName_ReturnsName_String()
        {
        string name = "Mark Zuckerberg";
        string date = "01/01/2011";
        string desc = "Facebook marketing";
        string cost = "$15,000";
		
		Order newOrder = new Order(name, date, desc, cost);
        string name1 = newOrder.Name;
        string date1 = newOrder.Date;
        string desc1 = newOrder.Desc;
        string cost1 = newOrder.Cost;

		Assert.AreEqual(name, name1);
        Assert.AreEqual(date, date1);
        Assert.AreEqual(desc, desc1);
        Assert.AreEqual(cost, cost1);
		
		}
		
		[TestMethod]
        public void GetAnotherName_SetName_String()
        {
        string name = "Jeff Bezos";
        Order newOrder = new Order(name, "07/05/1994", "Vendor since Amazon's day one as company!", "$12,000");

        string updatedName = "BezosRules";
        newOrder.Name = updatedName;
        string result = newOrder.Name;

        Assert.AreEqual(updatedName, result);
        }
		
		[TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
        List<Order> newList = new List<Order> { };

        List<Order> result = Order.GetAll();

        CollectionAssert.AreEqual(newList, result);
        }


    }
} 