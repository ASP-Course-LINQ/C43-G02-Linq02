using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ProductStateComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return x?.Category == y?.Category;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return HashCode.Combine(obj.Category);
        }
    }
}
