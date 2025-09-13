using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvpStudy.data;

namespace mvpStudy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class materiasController : ControllerBase
    {
        private readonly AppDbContext _appDbcontext;

        public materiasController(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }

        
    }
}