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
        public bool CheckSkinType(string skinType, string facialType)
        {
            if (skinType == "oily")
            {
                if (facialType == "Microdermabrasion" || facialType == "Rejuvenating")
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            else if (skinType == "combination")
            {
                if (facialType == "Microdermabrasion" || facialType == "Rejuvenating" || facialType == "Enzyme Peel")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (skinType == "normal")
            {
                return true;
            }
            else if (skinType == "dry")
            {
                if (facialType == "Microdermabrasion" || facialType == "Hydrofacial")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string name, string skintype, string manipedi)
        {
            List<string> facials = new List<string>()
            {
                "Microdermabrasion", "Hydrofacial", "Rejuvenating", "Enzyme Peel"
            };

            List<string> appropriateFacials = new List<string>();
            for (int i = 0; i < facials.Count; i++)
            {
                if (CheckSkinType(skintype, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }
            return View();
        }


    }
}
