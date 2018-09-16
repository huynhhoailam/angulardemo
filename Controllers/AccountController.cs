using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace AngularDemo.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    public class AccountController : Controller {
        private readonly ApplicationDBContext _context;

        public AccountController (ApplicationDBContext context) {
            _context = context;
        }

        
    }

}