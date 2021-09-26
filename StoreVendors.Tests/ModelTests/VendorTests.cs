using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreVendors.Models;
using System.Collections.Generic;
using System;

namespace StoreVendors.Tests
{
[TestClass]
public class VendorTest : IDisposable
	{
    public void Dispose()
    {
    Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_ReturnsInstance_Vendor()
    {
    Vendor newVendor = new Vendor("test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
	
	[TestMethod]
    public void GetName_ReturnsName_String()
    {
    string name = "Test Vendor";
    Vendor newVendor = new Vendor(name);

    string result = newVendor.Name;

    Assert.AreEqual(name, result);
    }

	[TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
    string name = "Test Vendor";
    Vendor newVendor = new Vendor(name);
    int result = newVendor.Id;
    Assert.AreEqual(1, result);
    }

	[TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
    string name01 = "Jeff Bezos";
    string name02 = "Bill Gates";
    Vendor newVendor1 = new Vendor(name01);
    Vendor newVendor2 = new Vendor(name02);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

	[TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
    string name01 = "Jeff Bezos";
    string name02 = "Bill Gates";
    Vendor newVendor1 = new Vendor(name01);
    Vendor newVendor2 = new Vendor(name02);
    Vendor result = Vendor.Find(2);
    Assert.AreEqual(newVendor2, result);
    }
	[TestMethod]
    public void AddOrder_OrderWithVendorMatch_OrderList()
    {
    string name1 = "Jeff Bezos";
    string desc1 = "Amazon provided our kitchen products";
    string date1 = "07/04/1994";
    string cost1 = "$33,000";
    Order newOrder = new Order(name1, desc1, date1, cost1);
    List<Order> newList = new List<Order> { newOrder };
    string desc2 = "Need more kitchen tools";
    Vendor newVendor = new Vendor(desc2);
    newVendor.AddOrder(newOrder);

	List<Order> result = newVendor.Orders;
	
	



    
	}

}