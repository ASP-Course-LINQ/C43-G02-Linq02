using System.Linq;
using System.Threading.Channels;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01 - Element Operators

            #region P01|Q01 - Get first Product out of Stock

            //var result = ProductsList.FirstOrDefault(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);//ProductID:5,ProductName:Chef Anton's Gumbo Mix,Category:Condiments,UnitPrice:$21.35,UnitsInStock:0

            #endregion

            #region P01|Q02 - Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductsList.FirstOrDefault(Product => Product.UnitPrice > 1000);
            //if(result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Items Founded!");

            #endregion

            #region P01|Q03 - Retrieve the second number greater than 5

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = arr.Order().Where(num => num>5).ElementAt(1);

            //Console.WriteLine(result);//7

            #endregion

            #endregion

            #region Part02 - Aggregate Operators

            #region P02|Q01 - Uses Count to get the number of odd numbers in the array

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = arr.Count(num => num % 2 == 1);
            //Console.WriteLine(result);//5

            #endregion

            #region P02|Q02 - Return a list of customers and how many orders each has.

            //var result = CustomersList.Select(customer => new { customer.CustomerID, orders = customer.Orders.Count()});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region P02|Q03 - Return a list of categories and how many products each has

            //var result = ProductsList.Select(product => new { product.Category, products = ProductsList.Count(product02 => product02.Category == product.Category) }).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region P02|Q04 - Get the total of the numbers in an array.

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = arr.Sum();
            //Console.WriteLine(result);//45

            #endregion

            #region P02|Q05 - Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] txtFile = File.ReadAllLines("dictionary_english.txt");

            //var result = txtFile.Sum(str => str.Length);

            //Console.WriteLine(result);//3494688

            #endregion

            #region P02|Q06 - Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] txtFile = File.ReadAllLines("dictionary_english.txt");

            //var result = txtFile.Where(str => str.Length>1).Min(str => str.Length);

            //Console.WriteLine(result);//2

            //var shortestWord = (from txt in txtFile
            //         where txt.Length == result
            //         select txt).First();

            //Console.WriteLine(shortestWord);//ab

            #endregion

            #region P02|Q07 - Get the length of the Longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] txtFile = File.ReadAllLines("dictionary_english.txt");

            //var result = txtFile.Max(str => str.Length);

            //Console.WriteLine(result);//31

            //var longestWord = (from txt in txtFile
            //                    where txt.Length == result
            //                    select txt).First();

            //Console.WriteLine(longestWord);//dichlorodiphenyltrichloroethane

            #endregion

            #region P02|Q08 - Get the Average Length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] txtFile = File.ReadAllLines("dictionary_english.txt");

            //var result = txtFile.Average(str => str.Length);

            //Console.WriteLine(result);//9.442576175563836

            #endregion

            #region P02|Q09 - Get the total units in stock for each product category.

            ////Fluent Syntax
            //var result = ProductsList.Select(p => p.Category).Distinct()
            //                         .Select(c => new
            //                         {
            //                             Category = c,
            //                             UnitsInStock = ProductsList.Where(p => p.Category == c)
            //                             .Sum(p => p.UnitsInStock)
            //                         });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var result02 = from p in ProductsList
            //             group p by p.Category into categories
            //             let total = categories.Sum(p => p.UnitsInStock)
            //             select new
            //             {
            //                 categories.Key,
            //                 UnitsInStock = total

            //             };
            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region P02|Q10 - Get the cheapest price among each category's products

            //var result = ProductsList.Min(p => p.UnitPrice);
            //Console.WriteLine($"{result:c}");//$2.50

            //var cheapestProduct = (from p in ProductsList
            //                       where p.UnitPrice == result
            //                       select p).FirstOrDefault();

            //Console.WriteLine(cheapestProduct);//ProductID:33,ProductName:Geitost,Category:Dairy Products,UnitPrice:$2.50,UnitsInStock:112

            #endregion

            #region P02|Q11 - Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductsList
            //             group p by p.Category into categories
            //             let minPrice = categories.Min(p => p.UnitPrice)
            //             from p in categories
            //             where p.UnitPrice == minPrice
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category:{item.Category}, Cheapest Product => {item}");
            //}

            #endregion

            #region P02|Q12 - Get the most expensive price among each category's products.

            //var result = from p in ProductsList
            //             group p by p.Category into categories
            //             let maxPrice = categories.Max(p => p.UnitPrice)
            //             //from p in categories
            //             select new
            //             {
            //                 Category = categories.Key,
            //                 MostExpensivePrice = $"{maxPrice:C}"
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region P02|Q13 - Get the products with the most expensive price in each category.


            //var result = from p in ProductsList
            //             group p by p.Category into categories
            //             let maxPrice = categories.Max(p => p.UnitPrice)
            //             from p in categories
            //             where p.UnitPrice == maxPrice
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category:{item.Category}, MaxPriceProduct => {item}");
            //}

            #endregion

            #region P02|Q14 - Get the average price of each category's products.

            //var result = from p in ProductsList
            //             group p by p.Category into categories
            //             let AvgPrice = categories.Average(p => p.UnitPrice)

            //             select new
            //             {
            //                 Category = categories.Key,
            //                 AvgPrice = AvgPrice
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Part03 - Set Operators

            #region P03|Q01 - Find the unique Category names from Product List

            ////01
            //var result = ProductsList.Union(ProductsList, new ProductStateComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Category);
            //}

            ////02
            //var result02 = ProductsList.DistinctBy(p => p.Category);

            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item.Category);
            //}

            #endregion

            #region P03|Q02 - Produce a Sequence containing the unique first letter from both product and customer names

            //var productNames = ProductsList.Select(p => p.ProductName.ElementAt(0));
            //var CustomerNames = CustomersList.Select(c => c.CustomerName.ElementAt(0));

            //var result = productNames.Union(CustomerNames);

            //Console.WriteLine(string.Join(", ", result));//C, A, G, U, N, M, I, Q, K, T, P, S, R, B, J, Z, V, F, E, W, L, O, D, H

            #endregion

            #region P03|Q03 - Create one sequence that contains the common first letter from both product and customer names.

            //var productNames = ProductsList.Select(p => p.ProductName.ElementAt(0));
            //var CustomerNames = CustomersList.Select(c => c.CustomerName.ElementAt(0));

            //var result = productNames.Intersect(CustomerNames);

            //Console.WriteLine(string.Join(", ", result));//C, A, G, N, M, I, Q, K, T, P, S, R, B, V, F, E, W, L, O

            #endregion

            #region P03|Q04 - Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var productNames = ProductsList.Select(p => p.ProductName.ElementAt(0));
            //var CustomerNames = CustomersList.Select(c => c.CustomerName.ElementAt(0));

            //var result = productNames.Except(CustomerNames);

            //Console.WriteLine(string.Join(", ", result));//U, J, Z

            #endregion

            #region P03|Q05 - Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            
            //var productNames = ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3));
            //var customerNames = CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3));

            //var result = productNames.Concat(customerNames);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

        }
    }
}
