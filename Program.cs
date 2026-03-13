using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Numerics;
using Task11_07_03_2026.Data;
using Task11_07_03_2026.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Task11_07_03_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            //1- List all customers' first and last names along with their email addresses.
            #region
            //var customers = _context.Customers.Select(c => new 
            //{ 
            //    c.FirstName, 
            //    c.LastName, 
            //    c.Email 
            //}).AsQueryable();
            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName},{item.Email}");
            //}
            #endregion


            //2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            #region
            //var orders_Staff = _context.Orders.Where(o => o.StaffId == 3).AsQueryable();

            //foreach (var item in orders_Staff)
            //{
            //    Console.WriteLine($"{item.StaffId},{item.OrderDate},{item.OrderStatus}");
            //}
            #endregion

            //3- Get all products that belong to a category named "Mountain Bikes".
            #region
            //var Product_CatName_MountainBikes = _context.Products.Include(o => o.Category).Where(p => p.Category.CategoryName == "Mountain Bikes").AsQueryable();
            //    foreach (var item in Product_CatName_MountainBikes)
            //    {
            //        Console.WriteLine($"{item.Category.CategoryName},{item.CategoryId},{item.ProductName} , {item.ModelYear} , {item.ListPrice}");
            //    }
            #endregion


            // 4-Count the total number of orders per store.
            #region
            //var NoOfOrderperStoreID = _context.Orders.GroupBy(o => o.StoreId).Select(e => new 
            //{
            //    e.Key,
            //    Count = e.Count()
            //}).AsQueryable();
            //foreach (var item in NoOfOrderperStoreID)
            //{
            //    Console.WriteLine($"{item.Key}            {item.Count}");
            //}
            #endregion


            //5- List all orders that have not been shipped yet (shipped_date is null).
            #region
            //var Orders_ShipedDateISNull = _context.Orders.Where(o => o.ShippedDate == null);
            //foreach (var item in Orders_ShipedDateISNull)
            //{
            //    Console.WriteLine($"{item.OrderId},            {item.OrderDate},  {item.ShippedDate}        ");
            //}
            #endregion


            //6 - Display each customer’s full name and the number of orders they have placed.
            // get informations by Searching
            #region
            //var GroupCustomerCountByOOrders = _context.Customers.Select(c => new 
            //{
            //    FullName = c.FirstName + " " + c.LastName,
            //    OrderCount = _context.Orders.Count(o => o.CustomerId == c.CustomerId)
            //}).AsQueryable();
            //foreach (var item in GroupCustomerCountByOOrders)
            //{
            //    Console.WriteLine($"{item.FullName},         {item.OrderCount}  ");
            //}
            #endregion

            #region
            //7 - List all products that have never been ordered(not found in order_items).
            //var NeverOrdere_Item = _context.Products.Where(p => !_context.OrderItems.Any(oi => oi.ProductId == p.ProductId)).AsQueryable();
            //foreach (var item in NeverOrdere_Item)
            //{
            //    Console.WriteLine($"{item.ProductId},     {item.ProductName},      {item.ModelYear}");
            //}
            #endregion


            //8- Display products that have a quantity of less than 5 in any store stock.
            #region
            //var StockLessThan5 = _context.Stocks.Include(p => p.Product).Where(s => s.Quantity<5).AsQueryable();
            //foreach (var item in StockLessThan5)
            //{
            //    Console.WriteLine($"{item.ProductId},         {item.Product.ProductName} ,   {item.Quantity}        ");
            //}
            #endregion


            //9- Retrieve the first product from the products table.
            #region
            //var FirstProduct = _context.Products.FirstOrDefault();
            //Console.WriteLine($"{FirstProduct.ProductId},  {FirstProduct.ProductName},    {FirstProduct.ModelYear}        ");
            #endregion


            //10- Retrieve all products from the products table with a certain model year.
            #region
            //var ProductsByYear = _context.Products.Where(p => p.ModelYear == 2018).AsQueryable();
            //foreach (var item in ProductsByYear)
            //{
            //    Console.WriteLine($"{item.ProductId},    {item.ProductName},    , {item.ModelYear}        ");
            //}
            #endregion

            //11- Display each product with the number of times it was ordered.
            #region
            //var ProductInOrderItemGroupByCount = _context.OrderItems.GroupBy(oi => oi.ProductId).Select(e => new 
            //{ 
            //    ProductId = e.Key,
            //    CountOrderes = e.Count() 
            //}).AsQueryable();
            //foreach (var item in ProductInOrderItemGroupByCount)
            //{
            //    Console.WriteLine($"{item.ProductId},         {item.CountOrderes}  ");
            //}
            #endregion

            //12- Count the number of products in a specific category.
            #region
            //int CategoryCountByCategoryISeq2 = _context.Products.Count(p => p.CategoryId == 2);
            //Console.WriteLine(CategoryCountByCategoryISeq2);
            #endregion
            //13- Calculate the average list price of products.
            #region
            //decimal AvgPrice = _context.Products.Average(p => p.ListPrice);
            //Console.WriteLine(AvgPrice);
            #endregion


            //14- Retrieve a specific product from the products table by ID.
            #region
            //var FirstProduct = _context.Products.FirstOrDefault(p => p.ProductId == 10);
            //Console.WriteLine($"{FirstProduct.ProductId},    {FirstProduct.ProductName},    , {FirstProduct.ModelYear}        ");
            #endregion


            //15- List all products that were ordered with a quantity greater than 3 in any order.
            //-------------------------------------------------
            //i am retriaved data from 3 table
            //--------------------------------------------------------------
            #region
            //var ProductOrderItemsOrdeasQuantityMorethan3 = _context.OrderItems.Include(p=>p.Product).Include(o => o.Order).Where(oi => oi.Quantity > 1).AsQueryable();
            //foreach (var item in ProductOrderItemsOrdeasQuantityMorethan3)
            //{
            //    Console.WriteLine($"{item.ProductId},  {item.Product.ProductName}, {item.Order.OrderDate}   , {item.Quantity}        ");
            //}
            #endregion


            //16- Display each staff member’s name and how many orders they processed.
            #region
            //var NoOfOrdersPerStaff = _context.Orders.GroupBy(o => o.Staff).Select(e=>new
            //{
            //    FullStaffName = e.Key.FirstName + " " + e.Key.LastName,
            //    NoOfOrders = e.Count()
            //}
            //).AsQueryable();
            //foreach (var item in NoOfOrdersPerStaff)
            //{
            //    Console.WriteLine($"{item.FullStaffName},      {item.NoOfOrders}");
            //}
            #endregion
            //17- List active staff members only (active = true) along with their phone numbers.
            #region
            //var StaffIsActive = _context.Staffs.Where(s => s.Active==1).Select(s => new 
            //{
            //    s.FirstName,
            //    s.LastName, 
            //    s.Phone 
            //}).AsQueryable();
            //foreach (var item in StaffIsActive)
            //{
            //    Console.WriteLine($"{item.FirstName},      {item.LastName},      {item.Phone}");
            //}
            #endregion

            //18- List all products with their brand name and category name.
            #region
            //var Product_Category_Brand_Details = _context.Products.Select(p => new 
            //{ 
            //    p.ProductName, 
            //    p.Brand.BrandName, 
            //    p.Category.CategoryName
            //}).AsQueryable();
            //--------------------------OtherSolution -----------------------------
            //var Product_Category_Brand_Details = _context.Products.Include(c => c.Category).Include(b => b.Brand).Select(e => new
            //{
            //    e.ProductName,
            //    e.Category.CategoryName,
            //    e.Brand.BrandName
            //}).AsQueryable();
            //foreach (var item in Product_Category_Brand_Details)
            //{
            //    Console.WriteLine($"{item.ProductName},      {item.BrandName},      {item.CategoryName}");
            //}
            #endregion

            //19- Retrieve orders that are completed.
            #region
            //var OrdersEqCompleted = _context.Orders.Where(o => o.OrderStatus == 4).Select(e => new
            //{
            //    e.OrderId,
            //    e.OrderItems,
            //    e.OrderDate,
            //    e.ShippedDate
            //}).AsQueryable();
            //foreach (var item in OrdersEqCompleted)
            //{
            //    Console.WriteLine($"{item.OrderId},      {item.OrderItems},      {item.OrderDate},      {item.ShippedDate}");
            //}
            #endregion
            //20- List each product with the total quantity sold (sum of quantity from order_items).
            #region
            var ProductGroupBy_SumOfQuantity = _context.OrderItems.GroupBy(oi => oi.Product).Select(e => new
            {
                e.Key,
                ProductName = e.Key.ProductName,
                SumOfTotalQuantity = e.Sum(oi=>oi.Quantity) 
            }).AsQueryable();
            foreach(var item in ProductGroupBy_SumOfQuantity)
            {
                Console.WriteLine($"{item.Key},      {item.ProductName},      {item.SumOfTotalQuantity}");
            }
            #endregion



        }
    }
}
