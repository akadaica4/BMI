using IndexBMI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexBMI.Controllers
{
    public class BMIController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BMIIndex());
        }
        [HttpPost]
        public IActionResult Index(BMIIndex bmiindex)
        {
            if (ModelState.IsValid)
            {
                var result = bmiindex.Weight / (bmiindex.Height * 2);
                if(result < 18.5)
                {
                    bmiindex.Result = "Thiếu cân";
                }else if(result < 24.9)
                {
                    bmiindex.Result = "Bình thường";
                }else if(result < 29.9)
                {
                    bmiindex.Result = "Thừa cân";
                }
                else if (result < 34.9)
                {
                    bmiindex.Result = "Béo phì cấp độ 1";
                }
                else if (result < 39.9)
                {
                    bmiindex.Result = "Béo phì cấp độ 2";
                }
                else if (result > 40)
                {
                    bmiindex.Result = "Béo phì cấp độ 3";
                }
            }
            return View(bmiindex);
        }
    }
}
