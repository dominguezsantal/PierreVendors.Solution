using System;
using System.Collections.Generic;

namespace StoreVendors.Models
{

public class Vendor
	{
    public string Name { get; set; }
    public int Id { get; }
    public static List<Vendor> _instances = new List<Vendor>();
    public List<Order> Orders { get; set; }

    public Vendor(string name)
    {
    Name = name;
    _instances.Add(this);
    Id = _instances.Count;
    Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
    _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
    return _instances;
    }
    public static Vendor Find(int searchId)
    {
    return _instances[searchId - 1];
    }
    public void AddOrder(Order order)
    {
    Orders.Add(order);
    }
	}
} 