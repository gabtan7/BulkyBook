using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        public void Update(ShoppingCart obj);

        public int IncrementCount (ShoppingCart obj, int count);
        public int DecrementCount(ShoppingCart obj, int count);
    }
}
