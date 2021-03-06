using Microsoft.AspNetCore.Mvc;
using StoreVendors.Models;
using System.Collections.Generic;

namespace StoreVendors.Controllers
{
public class OrdersController : Controller
{
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
    Vendor vendor = Vendor.Find(vendorId);
    return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
    Order orders = Order.Find(orderId);

    
    Vendor vendors = Vendor.Find(vendorId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("order", orders);
    model.Add("vendor", vendors);
    return View(model);
    }

    [HttpPost("/orders/delete")]
    public ActionResult Delete()
    {
    Order.ClearAll();
    return View();
    }
}
} 