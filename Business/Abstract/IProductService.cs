using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailsDto>> GetProductDetails();
        IDataResult<List<Product>> GetByUnitPrice(int min, int max);
        IDataResult<List<Product>> GetAllByCategory(int categoryId);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
