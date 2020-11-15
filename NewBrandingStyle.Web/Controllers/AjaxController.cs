using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AjaxController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;
        public AjaxController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(ExchangesModel exchange)
        {

            var entity = new ItemEntity
            {
                Name = exchange.Name,
                Description = exchange.Description,
                IsVisible = exchange.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
