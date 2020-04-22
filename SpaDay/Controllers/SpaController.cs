using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class SpaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method = 'post'>" +
                        "Name: <br>" +
                        "<input type = 'text' name = 'name'>" +
                        "<br>Skin type: <br>" +
                        "<select name = 'skintype'>" +
                        "<option value = 'oily'>Oily</option>" +
                        "<option value = 'combination'>Combination</option>" +
                        "<option value = 'normal'>Normal</option>" +
                        "<option value = 'dry'>Dry</option>" +
                        "</select><br>" +
                        "Manicure or Pedicure? <br>" +
                        "<select name = 'manipedi'>" +
                        "<option value = 'manicure'>Manicure</option>" +
                        "<option value = 'pedicure'>Pedicure</option>" +
                        "</select><br>" +
                        "<input type = 'submit' value = 'Submit'>" +
                        "</form>";
          
            return Content(html, "text/html");
        }

        

    }
}
