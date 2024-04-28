using Application.Interfaces;
using Core;
using Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        //Unit of Work
        private readonly OnlineShopDbContext _dbContext;

        public ProductService(OnlineShopDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<ProductDto> GEtAllProductAsync()
        {
            //AutoMapper
            throw new NotImplementedException();
        }
    }
}
