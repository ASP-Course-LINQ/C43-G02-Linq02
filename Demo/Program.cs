using System.Collections;
using System.IO;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 11 Element Operators - Immediate Execution [First() - Last() - LastOrDefault() - ElementAt() - Single() - SingleOrDefault()]
            //Valid Only With Fluent Syntax
            //You can use Hybrid Syntax (Query Expression).(Fluent Syntax).

            #region 01 - First

            #region 01.1 First() 

            ////return object of type nullable, so you need to check first if the returned is null or not before print the result
            ////Return The First Element/object inside the sequence [Return Only one element of type same as sequence type].
            ////Throw Exception if the sequence is empty [refer to empty object] or if the sequence refer to null.

            #region 01 - In Case the sequence is not empty.

            //var result = ProductsList.First();
            //    Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100

            #endregion

            #region 02 - In case the sequence is empty [Contain No Elements].

            //List<Product> list = new List<Product>();
            //var result = list.First();// System.InvalidOperationException: Sequence contains no elements

            //Console.WriteLine(result);

            #endregion

            #endregion

            #region 01.2 First(Func<Product,bool> predicate)
            //Returns The First Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => throw Exception (System.InvalidOperationException: Sequence contains no matching element)

            //Example -> Returns The first product out of stock.

            #region 01 - If there are elements matches the condition - returned the first element match.

            //var result = ProductsList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Throw Exception.

            //var result = ProductsList.First(p => p.UnitsInStock == 14569);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #region 03 - If Sequence is empty - throw Exception.

            //List<Product> products = new List<Product>();

            //var result = products.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 02 - Last

            #region 02.1 Last()

            ////Return The Last Element/object inside the sequence [Return Only one element of type same as sequence type].
            ////Throw Exception if the sequence is empty [refer to empty object] or if the sequence refer to "null".

            #region 01 - In case the sequence is not empty [Contain Elements]

            //var result = ProductsList.Last();

            //Console.WriteLine(result);//ProductID:77, ProductName:Original Frankfurter grüne Soße, Category:Condiments, UnitPrice:$13.00, UnitsInStock:32

            #endregion

            #region 02 - In case the sequence is empty [Contain No Elements].

            //List<Product> list = new List<Product>();
            //var result = list.Last();// System.InvalidOperationException: Sequence contains no elements

            //Console.WriteLine(result);

            #endregion

            ///First() - Last() =>
            ///Return the first or last item in the sequence if the sequence is not empty
            ///Throw Exception if the sequence is empty [contain no elements] or if it refer to "null".
            /// 

            #endregion

            #region 01.2 Last(Func<Product,bool> predicate)
            //Returns The Last Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => throw Exception (System.InvalidOperationException: Sequence contains no matching element)

            //Example -> Returns The Last product out of stock.

            #region 01 - If there are elements matches the condition - returned the Last element match.

            //var result = ProductsList.Last(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Throw Exception.

            //var result = ProductsList.Last(p => p.UnitsInStock == 14569);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #region 03 - If Sequence is empty - throw Exception.

            //List<Product> products = new List<Product>();

            //var result = products.Last(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 03 - FirstOrDefault

            #region 03.1 FirstOrDefault()

            //If the sequence is empty [contain no elements], returned the default value of the type of the sequence Type.
            //If the sequence is not empty, return the first element.

            #region 01 - In Case The sequence not empty [Contain Elements] - return the element.

            //var result = ProductsList.FirstOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100
            //else
            //    Console.WriteLine("");

            #endregion

            #region 02 - In case the sequence is empty [Contain no elements] - return the default value of Sequence type.

            //List<Product> list = new List<Product>();

            //var result = list.FirstOrDefault();
            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Items!");//No Items!
            //                                        //Because FirstOrDefault() here return the default value of type Product which is reference type and default value is "null"
            //                                        //This because the sequence is empty so the return is the default value "null" which holded in variable "result".

            #endregion

            #endregion

            #region 03.2 FirstOrDefault(Func<Product,bool> predicate)

            //Returns The First Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => return the default value of the sequenceType

            //Example -> Returns The first product out of stock.

            #region 01 - If there are elements matches the condition - returned the first element match.

            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Return the Default value of sequence type.

            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 14569);

            //if(result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #region 03 - If Sequence is empty - Return the Default value of sequence type.

            //List<Product> products = new List<Product>();

            //var result = products.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #endregion

            #endregion

            #region 04 - LastOrDefault

            #region 04.1 LastOrDefault()

            //If the sequence is empty [contain no elements], returned the default value of the type of the sequence Type ["0" => ValueTypes , "null" => ReferenceTypes].
            //If the sequence is not empty, return the Last element.

            #region 01 - In Case The sequence not empty [Contain Elements].

            //var result = ProductsList.LastOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);//ProductID:77, ProductName:Original Frankfurter grüne Soße, Category:Condiments, UnitPrice:$13.00, UnitsInStock:32
            //else
            //    Console.WriteLine("No Elements!");

            #endregion

            #region 02 - In case the sequence is empty [Contain no elements].

            //List<Product> list = new List<Product>();

            //var result = list.LastOrDefault();
            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Items!");//No Items!
            //                                        //Because FirstOrDefault() here return the default value of type Product which is reference type and default value is "null"
            //                                        //This because the sequence is empty so the return is the default value "null" which holded in variable "result".

            #endregion

            ///FirstOrDefault() - LastOrDefault() => 
            ///Return the first or last item in the sequence if the sequence is not empty
            ///Return the default value of the type of the sequence if the sequence is empty [Not thrown Exception] ["0" => ValueTypes , "null" => ReferenceTypes].
            /// 

            #endregion

            #region 04.2 LastOrDefault(Func<Product,bool> predicate)

            //Returns The Last Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => return the default value of the sequenceType

            //Example -> Returns The Last product out of stock.

            #region 01 - If there are elements matches the condition - returned the Last element match.

            //var result = ProductsList.LastOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID: 53, ProductName: Perth Pasties, Category:Meat / Poultry, UnitPrice:$32.80, UnitsInStock: 0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Return the Default value of sequence type.

            //var result = ProductsList.LastOrDefault(p => p.UnitsInStock == 14569);

            //if(result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #region 03 - If Sequence is empty - Return the Default value of sequence type.

            //List<Product> products = new List<Product>();

            //var result = products.LastOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #endregion

            #endregion

            #region 05 - ElementAt()

            //Return the element is specific index
            //If index is out of range of sequence indices or sequence is empty => throw exception (Index out of range).

            #region 01 - Try to return element in actual index in range of sequence indices.

            //var result = ProductsList.ElementAt(0);

            //Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100 

            #endregion

            #region 02 - Try to return element in Invalid index out of sequence indices range.

            //var result02 = ProductsList.ElementAt(100);

            //Console.WriteLine(result02);//System.ArgumentOutOfRangeException: Index was out of range. 

            #endregion

            #region 03 - Try to return element in empty sequence.

            //List<Product> products = new List<Product>();
            //var result03 = products.ElementAt(0);

            //Console.WriteLine(result03);//System.ArgumentOutOfRangeException: Index was out of range

            #endregion

            #endregion

            #region 06 - ElementAtOrDefault()

            //Return the element is specific index
            //If index is out of range of sequence indices or sequence is empty => Return The Default value of sequenceType.

            #region 01 - Try to return element in actual index in range of sequence indices.

            //var result = ProductsList.ElementAtOrDefault(0);

            //Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100 

            #endregion

            #region 02 - Try to return element in Invalid index out of sequence indices range.

            //var result02 = ProductsList.ElementAtOrDefault(100);

            //if(result02 != null)
            //    Console.WriteLine(result02);
            //else
            //    Console.WriteLine("index is out of range of sequence indices || sequence is empty");//index is out of range of sequence indices || sequence is empty

            #endregion

            #region 03 - Try to return element in empty sequence.

            //List<Product> products = new List<Product>();
            //var result03 = products.ElementAtOrDefault(0);

            //if (result03 != null)
            //    Console.WriteLine(result03);
            //else
            //    Console.WriteLine("index is out of range of sequence indices || sequence is empty");//index is out of range of sequence indices || sequence is empty

            #endregion

            #endregion

            #region 07 - Single

            #region 01 Single()

            //Return the only element of a sequence
            //Throw Exception => if the sequence not contain exactly one element. [System.InvalidOperationException: Sequence contains more than one element]
            //Throw Exception => if the sequence is empty. [System.InvalidOperationException: Sequence contain no elements]

            #region 01 - In case The sequence contain exactly one element

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100}
            //};

            //var result = products.Single();

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element.

            //var result = ProductsList.Single();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains more than one element

            #endregion

            #region 03 - In case The sequence is empty.

            //List<Product> products = new List<Product>();

            //var result = products.Single();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no elements

            #endregion

            #endregion

            #region 02 Single(Func<Product,bool> predicate)

            //Return the only element of a sequence that satisfy the specified condition
            //Throw Exception => if there are more than one element satisfy the condition [System.InvalidOperationException: Sequence contains more than one matching element]
            //Throw Exception => if the sequence not contain any elements match the condition or it's empty. [Sequence contains no matching element]

            #region 01 - In case The sequence contain exactly one element satisfy the condition

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.Single(p => p.UnitsInStock == 100);

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element satisfy the condition.

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.Single(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching elementt

            #endregion

            #region 03 - In case The sequence ot contain any elements match the condition or it's empty.

            //var result = ProductsList.Single(p => p.UnitsInStock == 700);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 07 - SingleOrDefault

            #region 01 SingleOrDefault()

            //Return the only element of a sequence
            //Return the default value of sequence Type if no elements exists [sequence is empty]
            //Throw Exception => if the sequence not contain exactly one element. [System.InvalidOperationException: Sequence contains more than one element]

            #region 01 - In case The sequence contain exactly one element

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100}
            //};

            //var result = products.SingleOrDefault();

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element.

            //var result = ProductsList.SingleOrDefault();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains more than one element

            #endregion

            #region 03 - In case The sequence is empty.

            //List<Product> products = new List<Product>();

            //var result = products.SingleOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Sequence is empty!");

            #endregion

            #endregion

            #region 02 SingleOrDefault(Func<Product,bool> predicate)

            //Return the only element of a sequence that satisfy the specified condition
            //Return the default value of sequence Type if no elements match the condition or sequence is empty.
            //Throw Exception => if there are more than one element satisfy the condition [System.InvalidOperationException: Sequence contains more than one matching element]

            #region 01 - In case The sequence contain exactly one element satisfy the condition

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 100);

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element satisfy the condition.

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching elementt

            #endregion

            #region 03 - In case No elements in sequence match the condition or  sequence is empty.

            //List<Product> products = new List<Product>()
            //{
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 0);

            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("there is No elements match the condition || Sequence is empty!");//there is No elements match the condition || Sequence is empty!

            #endregion

            #endregion

            #endregion

            #region Hybrid Syntax - QuerySyntax + FluentSyntax - (Query Expression).(Fluent Syntax[LinQ operator])

            ////Get the first element that units in stock of it is zero, get name,price,category.

            //var result = (from product in ProductsList
            //             where product.UnitsInStock == 0
            //             select new
            //             {
            //                 product.ProductName,
            //                 product.UnitPrice,
            //                 product.Category
            //             }).FirstOrDefault();

            //Console.WriteLine(result);//{ ProductName = Chef Anton's Gumbo Mix, UnitPrice = 21.3500, Category = Condiments }

            #endregion

            #endregion

            #region Part 12 Aggregate Operators - Immediate Ececution - [Count() - Max() - Min()- Sum() - Average() - Aggregate()]

            #region 01 - Count

            #region 01.1 Count<T>()
            ////return int value represent the numbers of elements in the sequence. 

            //var result = ProductsList.Count();//- LinQ operator - Return The Number of elements in the sequence.
            //var result02 = ProductsList.Count;//- List Property - That get the number of elements in the list that the reference "productList" refer to

            //Console.WriteLine(result);//77
            //Console.WriteLine(result02);//77 

            #endregion

            #region 01.1 Count<T>(Func<T,bool> predicate)
            ////Returns int value represent how many elements in the sequence that satisfied the predicate condition. 

            //var result = ProductsList.Count(product => product.UnitsInStock == 0);

            //Console.WriteLine(result);//5

            #endregion

            #endregion

            #region 02 - Max

            #region 02.1 Max<T>()
            ////Returns The Max value in the specified sequence based on default IComparable<T> if the class implement it.

            ////var result = ProductsList.Max();

            ////Console.WriteLine(result);//System.ArgumentException: At least one object must implement IComparable.

            ///the reference "productList" refer to object of type List<Product> which contain many Product objects
            ///and you need the maximum product, but CLR can't compare products objects with each other to know 
            ///what is the max product, so you must make class product implement IComparable<T> interface
            ///And provide Implementation for CompareTo(Product? other) to compare products objects based on specific property.


            ////After Make Class product implement IComparable<Product> And make CompareTo() compare based on Salary, to return the max product based on the salary.

            //var result = ProductsList.Max();

            //Console.WriteLine(result);//ProductID:38, ProductName:Côte de Blaye, CategoryBeverages, UnitPrice:$263.50, UnitsInStock:17

            #endregion

            #region 02.2 Max<T>(Func<T,decimal> selector)
            //Invokes the transform function on each sequence element and return the max decimal value.
            //Return Rhe Max selector value - not product.

            #region Ex01 - Get The Product With Max UnitPrice

            //var result = ProductsList.Max(product => product.UnitPrice);

            //Console.WriteLine(result);//263.5000

            //var MaxProductPrice = (from product in ProductsList
            //                      where product.UnitPrice == result
            //                      select product).FirstOrDefault();//Returns All products that has the specified price in condition and then select only one.

            //Console.WriteLine(MaxProductPrice);//ProductID:38, ProductName:Côte de Blaye, CategoryBeverages, UnitPrice:$263.50, UnitsInStock:17

            #endregion

            #region Ex02 - Get The product with max length name. 

            //var MaxLength = ProductsList.Max(product => product.ProductName.Length);

            //var MaxProductNameLength = (from Product in ProductsList
            //                           where Product.ProductName.Length == MaxLength
            //                           select Product).FirstOrDefault();

            //Console.WriteLine(MaxProductNameLength);//ProductID:65, ProductName:Louisiana Fiery Hot Pepper Sauce, CategoryCondiments, UnitPrice:$21.05, UnitsInStock:76

            #endregion

            #endregion

            #endregion

            #region 03 - Min

            #region 02.1 Min<T>()
            ////Returns The Min value in the specified sequence based on default IComparable<T> if the class implement it.

            ////var result = ProductsList.Max();

            ////Console.WriteLine(result);//System.ArgumentException: At least one object must implement IComparable.

            ///the reference "productList" refer to object of type List<Product> which contain many Product objects
            ///and you need the Minimum product, but CLR can't compare products objects with each other to know 
            ///what is the min product, so you must make class product implement IComparable<T> interface
            ///And provide Implementation for CompareTo(Product? other) to compare products objects based on specific property.


            ////After Make Class product implement IComparable<Product> And make CompareTo() compare based on Salary, to return the min product based on the salary.

            //var result = ProductsList.Min();

            //Console.WriteLine(result);//ProductID:33, ProductName:Geitost, CategoryDairy Products, UnitPrice:$2.50, UnitsInStock:112

            #endregion

            #region 02.2 Min<T>(Func<T,decimal> selector)
            //Invokes the transform function on each sequence element and return the min decimal value.
            //Return the Min selector value - not product.

            #region Ex01 - Get The Product With Min UnitPrice

            //var result = ProductsList.Min(product => product.UnitPrice);

            //Console.WriteLine(result);//2.5000

            //var MinProductPrice = (from product in ProductsList
            //                       where product.UnitPrice == result
            //                       select product).FirstOrDefault();//Returns All products that has the specified price in condition and then select only one.

            //Console.WriteLine(MinProductPrice);//ProductID:33, ProductName:Geitost, CategoryDairy Products, UnitPrice:$2.50, UnitsInStock:112

            #endregion

            #region Ex02 - Get The product with Min length name. 

            //var MinLength = ProductsList.Min(product => product.ProductName.Length);

            //var MinProductNameLength = (from Product in ProductsList
            //                            where Product.ProductName.Length == MinLength
            //                            select Product).FirstOrDefault();

            //Console.WriteLine(MinProductNameLength);//ProductID:1, ProductName:Chai, CategoryBeverages, UnitPrice:$18.00, UnitsInStock:100

            #endregion

            #endregion

            #endregion

            #region 04 - Sum<T>(Func<T,Tout> selector)
            ////Computes The Summation of the sequence "ProductList" of "T" " of type numerical" values
            ////that are i know the type of "T" from the type of selector "Function" "product => product.UnitsInStock"
            ////and return the summation of those values as "T".
            ////Computes The Sum of a sequence of "T" values that are obtained by invoking
            ////a transform function on each element of the input sequence 

            #region Ex - Sum of all units in stock.

            //var result = ProductsList.Sum(product => product.UnitsInStock);

            //Console.WriteLine(result);//3180 

            #endregion

            #endregion

            #region 05 - Average<T>(Func<T,Tout> selector)
            ////Get The Average of the specified selector values.
            ////And return the Average value as of type like selector property value.
            ////Computes The Average of a sequence of "T" values that are obtained by invoking
            ////a transform function on each element of the input sequence 

            //var result = ProductsList.Average(product => product.UnitPrice);

            //Console.WriteLine($"{result:c}");//$28.87

            #endregion

            #region 06 - Aggregate<T>(Func<T,T,T> func)

            ////Applies an Accumulator function over a sequence
            ////The parameter function take 2 inputs of type T and aggregate them and provide result of type T, 
            ////and then take result and aggregate it with another sequence value
            ////until sequence end.

            //string[] names = ["Eslam", "Ashraf", "Abdelazem", "Mohamed"];

            //var result = names.Aggregate((num01, num02) => $"{num01} {num02}");
            ///1st -> ("Eslam", "Ashraf") => Eslam Ashraf
            ///2nd -> ("Eslam Ashraf", "Abdelazem") => Eslam Ashraf Abdelazem
            ///3rd -> ("Eslam Ashraf Abdelazem", "Mohamed") => Eslam Ashraf Abdelazem Mohamed

            //Console.WriteLine(result);//Eslam Ashraf Abdelazem Mohamed

            #endregion

            #endregion

            #region Part 01 Casting[Conversion] Operators - Immediate Execution - [ToList() - ToArray() - ToDictionary() - OfType<T>()]
            //ToList() => Return A new List<T> object of The Source sequence elements.
            //ToArray() => Return A new object of type Array<T> contain The Source sequence elements.
            //ToDictionary() => Return A new object of type Dictionary<TKey,TValue> Contain The Source sequence elements (Dictionary<TKey,TValue> dictionary)
            //ToHashSet() => Return A new object of type HashSet<T> Contain The Source Sequence Elements.
            #region 01 - ToList<T>()
            ////ToList() => Return A new object of Type List<T> contain The Source sequence elements.

            //List<Product> result = ProductsList.Where(Product => Product.UnitsInStock == 0).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 02 - ToArray<T>()
            ////ToArray() => Return A new object of type Array<T> contain The Source sequence elements.

            //Product[] productsArr = ProductsList.Where(Product => Product.UnitsInStock == 0).ToArray();

            //foreach (var item in productsArr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 03 - ToDictionary

            #region 03.1 ToDictionary<TKey,TValue>(Func<T,TKey> keySelector)

            ////ToDictionary<TKey,TValue>(Func<T,TKey> keySelector) => Return A new object of type Dictionary<TKey,TValue> Contain The Source sequence elements (Dictionary<TKey,TValue>dictionary)
            ////                                                                                                              // Specify the Key here, and value specified as Product object.
            //Dictionary<long, Product> productsWithID = ProductsList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID);
            ///Dictionary is Generic collection store items as Key Value Pairs for each item, deal with Two generic types
            ///Tkey -> Represent The Type of the Key [long] - mean the key will be the ProductId which is of type long.
            ///TValue -> Represent The Type of the Value [Product] mean the value will be the Product object itself which is of type Product.

            ////product.productId => Key , product object itself => value

            //foreach (var item in productsWithID)
            //{
            //    Console.WriteLine($"Key: {item.Key} => Value: {item.Value}");
            //}
            //// Key: 5  => Value: ProductID:5, ProductName:Chef Anton's Gumbo Mix, CategoryCondiments, UnitPrice:$21.35, UnitsInStock:0
            //// Key: 17 => Value: ProductID:17, ProductName:Alice Mutton, CategoryMeat/Poultry, UnitPrice:$39.00, UnitsInStock:0
            //// Key: 29 => Value: ProductID:29, ProductName:Thüringer Rostbratwurst, CategoryMeat/Poultry, UnitPrice:$123.79, UnitsInStock:0
            //// Key: 31 => Value: ProductID:31, ProductName:Gorgonzola Telino, CategoryDairy Products, UnitPrice:$12.50, UnitsInStock:0
            //// Key: 53 => Value: ProductID:53, ProductName:Perth Pasties, CategoryMeat/Poultry, UnitPrice:$32.80, UnitsInStock:0

            #endregion

            #region 03.2 ToDictionary<TKey,TValue>(Func<T,TKey> keySelector, Func<T,TValue> valueSelector)

            //Dictionary<long, string> products = ProductsList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID,product => product.ProductName);

            ////product.productId => Key , product.productName => value

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Key: {item.Key} => Value: {item.Value}");
            //}
            ////Key: 5 => Value: Chef Anton's Gumbo Mix
            ////Key: 17 => Value: Alice Mutton
            ////Key: 29 => Value: Thüringer Rostbratwurst
            ////Key: 31 => Value: Gorgonzola Telino
            ////Key: 53 => Value: Perth Pasties

            #endregion

            #endregion

            #region 04 - ToHashSet<T>()

            //HashSet<Product> products = ProductsList.Where(product => product.UnitsInStock == 0).ToHashSet();

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}

            //// ProductID:5, ProductName:Chef Anton's Gumbo Mix, CategoryCondiments, UnitPrice:$21.35, UnitsInStock:0
            //// ProductID:17, ProductName:Alice Mutton, CategoryMeat/Poultry, UnitPrice:$39.00, UnitsInStock:0
            //// ProductID:29, ProductName:Thüringer Rostbratwurst, CategoryMeat/Poultry, UnitPrice:$123.79, UnitsInStock:0
            //// ProductID:31, ProductName:Gorgonzola Telino, CategoryDairy Products, UnitPrice:$12.50, UnitsInStock:0
            //// ProductID:53, ProductName:Perth Pasties, CategoryMeat/Poultry, UnitPrice:$32.80, UnitsInStock:0

            #endregion

            #region 05 - OfType<T>()
            ////Return A new object that contain elements of specific type only <T> and another elements in the source sequence will ignored.

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Eslam",
            //    "omar",
            //    "Ahmed",
            //    "Mona",
            //    "Aliaa",
            //    1,
            //    2,
            //    3,
            //    4,
            //    5,
            //    1.5m,
            //    2.5m,
            //    3.5m,
            //    4.5m,
            //    5.5m,
            //    true,
            //    true,
            //    false,
            //    false

            //};

            //var stringresult = arrayList.OfType<string>();
            //var Intresult = arrayList.OfType<int>();
            //var decimalresult = arrayList.OfType<decimal>();
            //var boolresult = arrayList.OfType<bool>();

            //Console.WriteLine(string.Join(", ", stringresult));//  Eslam, omar, Ahmed, Mona, Aliaa
            //Console.WriteLine(string.Join(", ", Intresult));//     1, 2, 3, 4, 5
            //Console.WriteLine(string.Join(", ", decimalresult));// 1.5, 2.5, 3.5, 4.5, 5.5
            //Console.WriteLine(string.Join(", ", boolresult));//    True, True, False, False


            #endregion

            #endregion

            #region Part 02 Generation Operators  - Deferred Execution - [Range() - Repeat() - Empty<T>()]
            //Valid Only With Fluent Syntax 
            //The Only Way To Call Those Generation LinQ operators is as static method - Throw Class Enumerable - Enumerable.LinQMethod(). 

            #region 01 - Range(int start, int count)
            ////Generate a sequence of integral numbers within a specific range
            ////Return IEnumerable<int> object that contain the range of sequential integral numbers.

            //var result = Enumerable.Range(0, 100);//start generate numbers from number 0 and generate 100 number.

            //Console.WriteLine(string.Join(", ", result));// 0 - 99  [100 number].

            #endregion

            #region 02 - Repeat<T>(T element,int count)
            ////Generate a sequence/object that contain one element repeated count numbers. 
            ////Return IEnumerable<out T> object that contain the a repeated element.

            //var result = Enumerable.Repeat("Eslam", 5);

            //Console.WriteLine(string.Join(", ", result));// Eslam, Eslam, Eslam, Eslam, Eslam

            //var result02 = Enumerable.Repeat(new Product() { ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11}, 6);

            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //}

            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11

            #endregion

            #region 03 - Empty<T>()
            //Returns an empty IEnumerable<out T> object. 

            #region Example01 - var result = Enumerable.Empty<Product>();

            //var result = Enumerable.Empty<Product>();
            ////result now refer to nothing

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//Print Nothing.
            //} 

            #endregion

            #region Example02 - Product[] products = new Product[0];

            ////Previous Example Like Initialize reference of type Product[] and let it refer to empty object that contain 0 product object. 
            //Product[] products = new Product[0];
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);//Print Nothing
            //} 

            #endregion

            #region Example03 - List<Product> products = new List<Product>();

            ////This Example Like The Example01.

            //List<Product> products = new List<Product>();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);//print Nothing
            //}

            #endregion

            #region Example04 - var result02 = new Product();

            //var result02 = new Product();//Make New object of type product and initialize it's properties with default value of the type.
            //Console.WriteLine(result02);//Print state of the product that initialized with default value.
            //                            //ProductID:0, ProductName:, Category:, UnitPrice:$0.00, UnitsInStock:0

            #endregion

            #endregion

            #endregion

            #region Part 03 Set Operators[Union Family] - Deferred Execution - [Union() - Concat() - Intersect() - Except() - Distinct()]
            //Those Operators Are Work On 2 Sequences with same dataType.

            #region 01 - Union
            ///Produce The Set union of two sequences by using the default equallity comparer of the type.
            ///Return The new Sequence that contain the elements from both input sequences, exluding duplicates [specify duplicate based on default EquallityComparer of type].
            ///The Default Equality comparer of ValueTypes -> Compare Based on state(data).
            ///The Default Equality comparer of ReferenceTypes -> Compare Based on Reference(Address) of the objects.
            ///If You need to provide new EqualityComparer behaviour to the type, use the second overload of union 
            ///Union<T>(IEnumerable<T> second, IEqualityComparer<T>? comparer)

            #region 01 Union<T>(IEnumerable<T> second) - Exlude Duplicates based on Default EqualityComparer of sequences Type. 

            #region Example01 - The 2 Sequences are of type valueType <int> - So The Comparing is based on state/Data to specify if the 2 objects are the same

            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(5, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.Union(seq02);

            //Console.WriteLine(string.Join(", ", result));
            ////0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - So The Comparing is based on Reference/Address to specify if the 2 objects are the same

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but differenct Addresses in heap
            ///So now when use first overload of  Union<T>(IEnumerable<T> second) that not take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity betwwen objects will be based on the default Comparer of referenceTypes which is based on Address of objects
            ///So the result of the Union() here will be new sequence contain 8 product objects.
            ///

            //var result = products01.Union(products02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #region 02 Union<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) - Exlude Duplicates based on Specific EqualityComparer.

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - and The Comparing will be based on specify EquallityComparer - Compare based on objectStates not references.

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but difference Addresses in heap
            ///So now when use Second overload of Union<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) that take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the Specify Comparer of "IEquallityComparer<T>? comparer" which is based on State of objects
            ///So the result of the Union here will be new sequence contain 4 products objects only
            ///Because The Second Sequence "seq02" contain the same objects state of "seq01" objects. 
            ///

            //var result = products01.Union(products02, new ProductEqualityComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #endregion

            #region 02 - Concat<T>(IEnumerable<T> second)
            //Concatenates the two sequences in one sequence without ignore duplicates
            //Returns object of type IEnumerable<out T> That contain the Concatenate elements of the 2 input sequences

            #region Example01 - The 2 Sequences are of type valueType <int>.

            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(5, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.Concat(seq02);

            //Console.WriteLine(string.Join(", ", result));
            ////0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> .

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //var result = products01.Concat(products02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #region 03 - Intersect
            ///Produce The set intersection of two sequences by using the default equality comparer to compare elements.
            ///Return The new Sequence that contain the Intersection Elements of both input sequences [specify Intersect based on default EquallityComparer of type].
            ///The Default Equality comparer of ValueTypes -> Compare Based on state(data).
            ///The Default Equality comparer of ReferenceTypes -> Compare Based on Reference(Address) of the objects.
            ///If You need to provide new EqualityComparer behaviour to the type, use the second overload of Intersect 
            ///intersect<T>(IEnumerable<T> second, IEqualityComparer<T>? comparer)

            #region 01 Intersect<T>(IEnumerable<T> second) - Return Intersection Elements based on Default EqualityComparer of sequences Type. 

            #region Example01 - The 2 Sequences are of type valueType <int> - So The Comparing is based on state/Data to specify if the 2 objects are the same

            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(5, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.Intersect(seq02);

            //Console.WriteLine(string.Join(", ", result));
            ////5, 6, 7, 8, 9

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - So The Comparing is based on Reference/Address to specify if the 2 objects are the same

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but differenct Addresses in heap
            ///So now when use first overload of  Intersect<T>(IEnumerable<T> second) that not take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the default Comparer of referenceTypes which is based on Address of objects
            ///So the result of the Intersect here will be new sequence contain 0 product objects
            ///because it found that there are no object has the same address like another object in second sequence to return it.
            ///

            //var result = products01.Intersect(products02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//Nothing
            //}

            #endregion

            #endregion

            #region 02 Intersect<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) - Return Intersected Elements based on Specific EqualityComparer.

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - and The Comparing will be based on specify EquallityComparer - Compare based on objectStates not references.

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but difference Addresses in heap
            ///So now when use Second overload of Intersect<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) that take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the Specify Comparer of "IEquallityComparer<T>? comparer" which is based on State of objects
            ///So the result of the Union here will be new sequence contain 4 products objects
            ///Because Those Are The objects which are founded in the 2 sequence with same state.
            ///

            //var result = products01.Intersect(products02, new ProductEqualityComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #endregion

            #region 04 - Except
            ///Produce The set Difference of two sequences by using the default equality comparer to compare elements.
            ///Return The new Sequence that contain the set Elements that found in ("seq01" => Caller of LinQ method Except()) and not founded in ("seq02" => Parameter of LinQ method Except()) [specify Difference based on default EquallityComparer of type].
            ///The Default Equality comparer of ValueTypes -> Compare Based on state(data).
            ///The Default Equality comparer of ReferenceTypes -> Compare Based on Reference(Address) of the objects.
            ///If You need to provide new EqualityComparer behaviour to the type, use the second overload of Intersect 
            ///Except<T>(IEnumerable<T> second, IEqualityComparer<T>? comparer)

            #region 01 Except<T>(IEnumerable<T> second) - Return Differnce Elements That found in first sequence and not founded in second sequence based on Default EqualityComparer of sequences Type. 

            #region Example01 - The 2 Sequences are of type valueType <int> - So The Comparing is based on state/Data to specify if the 2 objects are the same to return elements found in "seq01" and not in "seq02"

            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(5, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.Except(seq02);

            //Console.WriteLine(string.Join(", ", result));
            ////0, 1, 2, 3, 4

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - So The Comparing is based on Reference/Address to specify if the 2 objects are the same to return elements found in "seq01" and not in "seq02"

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but differenct Addresses in heap
            ///So now when use first overload of  Except<T>(IEnumerable<T> second) that not take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the default Comparer of referenceTypes which is based on Address of objects
            ///So the result of the Except here will be new sequence contain 4 product objects
            ///because it found that there are 4 object in "seq01" with address not like any addressed of objects in second sequence "seq02".
            ///

            //var result = products01.Except(products02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//Nothing
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #region 02 Except<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) - Return Difference Elements based on Specific EqualityComparer.

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - and The Comparing will be based on specify EquallityComparer - Compare based on objectStates not references.

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but difference Addresses in heap
            ///So now when use Second overload of Except<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) that take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the Specify Comparer of "IEquallityComparer<T>? comparer" which is based on State of objects
            ///So the result of the Except here will be new sequence contain 0 products objects
            ///Because We need To return only objects found in first sequence and not found in second sequence
            ///And the first sequence and second sequence contain the same objects with same state, and we compare based on state, we return difference based on state of objects.
            ///

            //var result = products01.Except(products02, new ProductEqualityComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//Nothing
            //}

            #endregion

            #endregion

            #endregion

            #region 05 - Distinct
            //Return Distinct Elements from a sequence by using the default equality comparer to compare sequence elements.
            //Return IEnumerable<out T> that contain distinct elements of the source sequence without duplicates.

            #region 01 Distinct<T>()

            #region Example01 - The Sequence is of type valueType <int> - So The Comparing between sequence elements to found the duplicates will be based on state.

            //List<int> seq01 = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 5, 8, 9, 9, 7, 1, 6 };
            //var result = seq01.Distinct();

            //Console.WriteLine(string.Join(", ", result));
            ////1, 2, 3, 4, 5, 8, 9, 7, 6

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> -So The Comparing between sequence elements to found the duplicates will be based on Reference/Address of sequence objects.

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The sequence contain objects with the same states but differenct Addresses in heap
            ///So now when use first overload of  Distinct<T>() that not take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between sequence objects will be based on the default Comparer of referenceTypes which is based on Address of objects
            ///So the result of the Distinct here will be new sequence contain 8 product objects [With Duplicate State Objects]
            ///Because it deal with sequence objects as different objects because they have different addresses [But there are objects duplicated that has the same state].
            ///

            //var result = products01.Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #region 02 Distinct<T>(IEquallityComparer<T>? comparer) - Return new sequence with distinct elements of source sequence based on Specific EqualityComparer.

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - and The Comparing will be based on specify EquallityComparer - Compare based on objectStates not references.


            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The sequence contain objects with the same states but differenct Addresses in heap
            ///So now when use first overload of  Distinct<T>(IEqualityComparer<T>? comparer) that take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between sequence objects will be based on the Specific Comparer based on State of objects not address.
            ///So the result of the Distinct here will be new sequence contain only 4 product objects [Without Duplicate State Objects]
            ///Because it deal with sequence objects as same objects because they have same state [But different addresses].
            ///

            //var result = products01.Distinct( new ProductEqualityComparer());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// ProductID:1, ProductName:Chai, Category:XYZ, UnitPrice:$100.00, UnitsInStock:11
            //// ProductID:2, ProductName:Cheese, Category:ABC, UnitPrice:$150.00, UnitsInStock:20
            //// ProductID:3, ProductName:Panana, Category:GTY, UnitPrice:$100.00, UnitsInStock:140
            //// ProductID:4, ProductName:Cherry, Category:CDE, UnitPrice:$100.00, UnitsInStock:0

            #endregion

            #endregion

            #endregion

            #endregion

            #region Part 04 Quantifier Operators - Deferred Execution - Return Boolean - [Any() - All() - SequenceEqual()]

            #region 01 - Any

            #region 01.1 Any<T>()
            ////Determine Whether a sequence contains any elements
            ////Return Boolean value -> True if source sequence contains any elements, otherwise return False.

            //var result = ProductsList.Any();
            //Console.WriteLine(result);//True

            #endregion

            #region 01.2 Any<T>(Func<T,bool> predicate)
            ////Determine Whether any element of a sequence satisfy a condition.
            ////Return Boolean value ->
            ////True => if source sequence is not empty and and at least one of its elements pass the predicate condition
            ////otherwise return False [if there is no any element in sequence match the condition].

            //var result = ProductsList.Any(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);//True

            //result = ProductsList.Any(product => product.UnitsInStock > 1000);
            //Console.WriteLine(result);//False [There is no products that units in stock of it > 1000].
            #endregion

            #endregion

            #region 02 - All<T>(Func<T,bool> predicate)
            //Determines whether all elements of a sequence satisfy a condition
            //Return True if the sequence is empty or every element in the source sequence passes the predicate test 
            //Otherwise Return False.

            #region Example01 - If not all source sequence elements match the condition  Return "False"

            //var result = ProductsList.All(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);//False 

            #endregion

            #region Example02 - If All Sequence elements pass the condition - Return "True"

            //int[] nums = [2, 4, 6, 8, 10];

            //var result = nums.All(num => num % 2 == 0);
            //Console.WriteLine(result);//True [All Elements in the sequence pass the condition [num%2 == 0]].

            #endregion

            #region Example03 - If Sequence Is Empty - Return "True".

            //List<int> nums = new List<int>();

            //var result = nums.All(num => num % 2 == 0);
            //Console.WriteLine(result);//True

            #endregion

            #endregion

            #region 03 - SequenceEqual
            //Determine Whether The 2 sequences have the same elements.

            #region 01 SequenceEqual<T>(IEnumerable<T> second)
            ///Determine Whether The 2 sequences have the same elements. by using the default equality comparer of the type.
            ///Compare based on state/data => ValueType data types default comparer
            ///Compare based on Reference/Address => ReferenceType data types default comparer
            ///Return True if the 2 sequences have the same elements 
            ///otherwise return False. 

            #region Example01 - The 2 Sequences are of type valueType <int> - So The Comparing is based on state/Data to specify if the 2 objects are the same

            ////01 - If The 2 sequences not equals in the length and state.
            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(5, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.SequenceEqual(seq02);
            //Console.WriteLine(result);//False


            ////02 - If The 2 sequences equals in the length and state.
            //List<int> seq01 = Enumerable.Range(0, 10).ToList();//0,1,2,3,4,5,6,7,8,9
            //List<int> seq02 = Enumerable.Range(0, 10).ToList();//5,6,7,8,9,10,11,12,13,14

            //var result = seq01.SequenceEqual(seq02);
            //Console.WriteLine(result);//True

            #endregion

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - So The Comparing is based on Reference/Address to specify if the 2 objects are the same

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but differenct Addresses in heap and the 2 sequences have the same length.
            ///So now when use first overload of  SequenceEquals<T>(IEnumerable<T> second) that not take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the default Comparer of referenceTypes which is based on Address of objects
            ///So the result of the SequenceEquals here will be False here.
            ///because it found that objects in first sequence not like objects in second sequence based on Address.[But the objects have the same state].
            ///

            //var result = products01.SequenceEqual(products02);
            //Console.WriteLine(result);//False

            #endregion

            #endregion

            #region 02 SequenceEqual<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) - Return Bool value based on Specific EqualityComparer.

            #region Example02 - The 2 Sequences are of type ReferenceType <Product> - and The Comparing will be based on specify EquallityComparer - Compare based on objectStates not references.

            //List<Product> products01 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};

            //List<Product> products02 = new List<Product>()
            //{
            //    new Product(){ ProductID = 1, ProductName = "Chai", Category = "XYZ", UnitPrice = 100, UnitsInStock = 11},
            //    new Product(){ ProductID = 2, ProductName = "Cheese", Category = "ABC", UnitPrice = 150, UnitsInStock = 20},
            //    new Product(){ ProductID = 3, ProductName = "Panana", Category = "GTY", UnitPrice = 100, UnitsInStock = 140},
            //    new Product(){ ProductID = 4, ProductName = "Cherry", Category = "CDE", UnitPrice = 100, UnitsInStock = 0}
            //};
            ///The 2 sequences contain the objects with the same states but difference Addresses in heap
            ///So now when use Second overload of SequenceEqual<T>(IEnumerable<T> second, IEquallityComparer<T>? comparer) that take parameter of type IEquallityComparer<T> 
            ///The Compare Equallity between objects will be based on the Specify Comparer of "IEquallityComparer<T>? comparer" which is based on State of objects
            ///So the result of the SequenceEqual here will be Trur
            ///because it found that objects in first sequence like objects in second sequence based on State Comparer.[But the objects have the Different Addresses].
            ///

            //var result = products01.SequenceEqual(products02, new ProductEqualityComparer());
            //Console.WriteLine(result);//True
    
            #endregion

            #endregion

            #endregion

            #endregion

        }
    }
}
