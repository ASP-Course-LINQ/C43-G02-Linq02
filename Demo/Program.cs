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

        }
    }
}
