using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.InterfaceLayer.Abstract;
using Nortwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nortwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ApiBaseController<IRegionService, Region, DtoRegion>
    {
        public RegionController(IRegionService service) : base(service)
        {

        }
    }
}
