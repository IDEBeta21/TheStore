using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcomService.API.Models;
using EcomService.API.Models.Dto;
using EcomService.API.Models.Dto.Product;

namespace EcomService.API.Services.StoreServices
{
    public interface IStoreService
    {
        Task<ServiceResponse<List<string>>> GetAllStoreType();
        Task<ServiceResponse<Boolean>> InsertStoreType(string storeType);
    }
}