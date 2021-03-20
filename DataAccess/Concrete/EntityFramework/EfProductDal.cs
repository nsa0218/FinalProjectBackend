using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, NorthwindContext>, IProductDal

    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailsDto
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();
            }
         
           
        }
    }
}
