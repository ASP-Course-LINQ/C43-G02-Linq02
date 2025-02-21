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
        }
    }
}
