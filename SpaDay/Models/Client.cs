using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class Client
    {
        [FromForm(Name="skintype")]
        public string SkinType { get; set; }
        [FromForm(Name="manipedi")]
        public string NailService { get; set; }
        private List<string> appropriateFacials = new List<string>();

        public Client()
        {

        }

        public Client(string skinType, string nailService)
        {
            SkinType = skinType;
            NailService = nailService;
            SetFacials(SkinType);
        }

        public List<string> GetFacials()
        {
            return appropriateFacials;
        }

        public bool CheckSkinType(string skinType, string facialType)
        {

            if (facialType != "Microdermabrasion")
            {
                if (skinType == "oily" && facialType != "Rejuvenating")
                {
                    return false;
                }
                else if (skinType == "combination" && (facialType != "Rejuvenating" || facialType != "Enzyme Peel"))
                {
                    return false;
                }
                else if (skinType == "dry" && facialType != "Hydrofacial")
                {
                    return false;
                }
            }

            return true;

        }

        public void SetFacials(String skinType)
        {
            List<String> facials = new List<String>();
            facials.Add("Microdermabrasion");
            facials.Add("Hydrofacial");
            facials.Add("Rejuvenating");
            facials.Add("Enzyme Peel");

            for (int i = 0; i < facials.Count; i++)
            {
                if (CheckSkinType(skinType, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }
        }
    }
}
