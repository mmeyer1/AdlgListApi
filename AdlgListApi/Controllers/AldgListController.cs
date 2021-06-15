using AdlgListApi.Handlers;
using AdlgListApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdlgListOptionsController
    {
        private IAdlgListHandler ListHandler; 
        public AdlgListOptionsController(IAdlgListHandler listHandler)
        {
            ListHandler = listHandler;
        }

        [HttpGet]
        public async Task<ArmyListOptions> Get(ListRequest request)
        {
            return await ListHandler.HandleGetOptionAsync(request.ListNumber);
        }
    }
}
