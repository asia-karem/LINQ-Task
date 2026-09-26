using LINQ_Task.Data;

namespace LINQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _contest = new ApplicationDbContext();

            // 1-List all customers' first and last names along with their email addresses.
           

            var customers = _contest.Customers.Select(c => new
                {
                    c.FirstName,
                    c.LastName,
                    c.Email
                });

            foreach (var customer in customers)
            {
                Console.WriteLine( $"{customer.FirstName} {customer.LastName} , {customer.Email}");
            }

            // 2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).

            var ordersByStaff = _contest.Orders.Where(o => o.StaffId == 3);

            foreach (var order in ordersByStaff)
            {
                Console.WriteLine($"Order ID: {order.OrderId} , Staff ID: {order.StaffId}");
            }
            // 3- Get all products that belong to a category named "Mountain Bikes".

            var mountainBikes = _contest.Products.Where(p => p.Category.CategoryName == "Mountain Bikes");

            foreach (var product in mountainBikes)
            {
                Console.WriteLine($"{product.ProductId} , {product.ProductName}");
            }

            // 4-Count the total number of orders per store.

            var ordersPerStore = _contest.Orders.GroupBy(o => o.StoreId).Select(g => new
                {
                    StoreId = g.Key,
                    OrdersCount = g.Count()
                });

            foreach (var store in ordersPerStore)
            {
                Console.WriteLine($"Store ID: {store.StoreId} , Orders: {store.OrdersCount}");
            }

            // 5- List all orders that have not been shipped yet (shipped_date is null).

            var notShipped = _contest.Orders.Where(o => o.ShippedDate == null);

            foreach (var order in notShipped)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
            }

            // 6- Display each customer’s full name and the number of orders they have placed.

            var customerOrders = _contest.Customers.Select(c => new
                {
                    FullName = c.FirstName + " " + c.LastName,
                    OrdersCount = c.Orders.Count()
                });

            foreach (var customer in customerOrders)
            {
                Console.WriteLine($"{customer.FullName} , Orders: {customer.OrdersCount}");
            }

            // 7- List all products that have never been ordered (not found in order_items).

            var neverOrdered = _contest.Products.Where(p => !p.OrderItems.Any());

            foreach (var product in neverOrdered)
            {
                Console.WriteLine($"{product.ProductId} , {product.ProductName}");
            }

            // 8- Display products that have a quantity of less than 5 in any store stock.

            var lowStock = _contest.Stocks.Where(s => s.Quantity < 5);

            foreach (var stock in lowStock)
            {
                Console.WriteLine($"Product ID: {stock.ProductId} , Quantity: {stock.Quantity}");
            }

            // 9- Retrieve the first product from the products table.


            var firstProduct = _contest.Products.FirstOrDefault();

            if (firstProduct != null)
            {
                Console.WriteLine($"{firstProduct.ProductId} , {firstProduct.ProductName}");
            }

            // 10- Retrieve all products from the products table with a certain model year.

            int year = 2018;

            var productsByYear = _contest.Products.Where(p => p.ModelYear == year);

            foreach (var product in productsByYear)
            {
                Console.WriteLine($"{product.ProductName} , {product.ModelYear}");
            }

            // 11- Display each product with the number of times it was ordered.

            var productOrderCount = _contest.Products
               .Select(p => new
               {
                   p.ProductName,
                   OrdersCount = p.OrderItems.Count()
               });

            foreach (var product in productOrderCount)
            {
                Console.WriteLine($"{product.ProductName} , Ordered: {product.OrdersCount} times");
            }

            // 12- Count the number of products in a specific category.

            int categoryId = 1;

            var categoryCount = _contest.Products.Count(p => p.CategoryId == categoryId);

            Console.WriteLine($"Products Count: {categoryCount}");

            // 13- Calculate the average list price of products.

            var averagePrice = _contest.Products.Average(p => p.ListPrice);

            Console.WriteLine($"Average List Price: {averagePrice}");

            // 14- Retrieve a specific product from the products table by ID.

            int productId = 1;

            var productById = _contest.Products.FirstOrDefault(p => p.ProductId == productId);

            if (productById != null)
            {
                Console.WriteLine($"{productById.ProductId} , {productById.ProductName}");
            }

            // 15- List all products that were ordered with a quantity greater than 3 in any order.

            var productsQuantityGreaterThan3 = _contest.Products.Where(p => p.OrderItems.Any(o => o.Quantity > 3));

            foreach (var product in productsQuantityGreaterThan3)
            {
                Console.WriteLine($"{product.ProductId} , {product.ProductName}");
            }

            // 16- Display each staff member’s name and how many orders they processed.

            var staffOrders = _contest.Staffs.Select(s => new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    OrdersCount = s.Orders.Count()
                });

            foreach (var staff in staffOrders)
            {
                Console.WriteLine( $"{staff.FullName} , Orders: {staff.OrdersCount}");
            }

            // 17- List active staff members only (active = true) along with their phone numbers.

            var activeStaff = _contest.Staffs.Where(s => s.Active == 1 ).Select(s => new
    {
            FullName = s.FirstName + " " + s.LastName, s.Phone
            });

            foreach (var staff in activeStaff)
            {
                Console.WriteLine($"{staff.FullName} , {staff.Phone}");
            }
            // 18- List all products with their brand name and category name.

            var productDetails = _contest.Products.Select(p => new
                {
                    p.ProductName,
                    BrandName = p.Brand.BrandName,
                    CategoryName = p.Category.CategoryName
                });

            foreach (var product in productDetails)
            {
                Console.WriteLine($"{product.ProductName} , {product.BrandName} , {product.CategoryName}");
            }

            // 19- Retrieve orders that are completed.

            var completedOrders = _contest.Orders.Where(o => o.OrderStatus == 4);

            foreach (var order in completedOrders)
            {
                Console.WriteLine($"Order ID: {order.OrderId} , Status: {order.OrderStatus}");
            }

            // 20- List each product with the total quantity sold (sum of quantity from order_items).

            var totalQuantitySold = _contest.Products.Select(p => new
            {
               p.ProductName,
               TotalQuantity = p.OrderItems.Sum(o => o.Quantity)
            });

            foreach (var product in totalQuantitySold)
            {
                Console.WriteLine($"{product.ProductName} , {product.TotalQuantity}");
            }

        }
    }
}
