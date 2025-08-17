using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcomService.API.Data;
using EcomService.API.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace EcomService.API.Services.StoreServices
{
    public class StoreService : IStoreService
    {
        private readonly StoreDataContext _context;
        public StoreService(StoreDataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<string>>> GetAllStoreType()
        {
            var response = new ServiceResponse<List<string>>();
            List<string> typeList = new List<string>();

            try
            {
                var storeTypes = await _context.StoreTypes.ToListAsync();
                foreach (var type in storeTypes) { typeList.Add(type.Name); }

                response.success = true;
                response.message = "Store types found";
                response.data = typeList;
            }
            catch (System.Exception)
            {
                response.success = false;
                response.message = "Store types not found";
                throw;
            }

            return response;
        }

        public Task<ServiceResponse<bool>> InsertStoreType(string storeType)
        {
            throw new NotImplementedException();
            //test
        }
    }
}