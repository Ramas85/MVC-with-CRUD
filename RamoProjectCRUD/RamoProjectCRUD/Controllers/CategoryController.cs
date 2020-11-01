using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RamoProjectCRUD.Data;

namespace RamoProjectCRUD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController() 
        {

        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
