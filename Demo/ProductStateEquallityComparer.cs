using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ProductStateEquallityComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return (x?.ProductID.Equals(y?.ProductID)?? y == null ? true : false) && (x?.ProductName.Equals(y.ProductName) ?? y is null ? true : false) && (x?.UnitPrice.Equals(y?.UnitPrice) ?? y is null ? true : false) && (x?.Category.Equals(y?.Category) ?? y is null ? true : false) && (x?.UnitsInStock.Equals(y?.UnitsInStock) ?? y is null ? true : false);
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return HashCode.Combine(obj.ProductID,obj.ProductName,obj.UnitPrice,obj.Category,obj.UnitsInStock);
        }
    }
}
