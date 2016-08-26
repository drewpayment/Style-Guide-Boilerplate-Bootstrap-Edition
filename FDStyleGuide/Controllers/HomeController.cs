using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FDStyleGuide.Models;

namespace FDStyleGuide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Freedom Dev Style Guide";

            var componentGroup = new Component()
            {
                BaseList = new List<BaseComponent>()
                {
                    new BaseComponent() { Name = "Address" },
                    new BaseComponent() { Name = "Badges" },
                    new BaseComponent() { Name = "Blockquote" },
                    new BaseComponent() { Name = "Buttons" },
                    new BaseComponent() { Name = "Code" },
                    new BaseComponent() { Name = "Definition-Lists" },
                    new BaseComponent() { Name = "Form-Controls" },
                    new BaseComponent() { Name = "Headings" },
                    new BaseComponent() { Name = "Images" },
                    new BaseComponent() { Name = "Labels" },
                    new BaseComponent() { Name = "Lists" },
                    new BaseComponent() { Name = "Progress-Bars" },
                    new BaseComponent() { Name = "Tables" },
                    new BaseComponent() { Name = "Text-Elements" },
                    new BaseComponent() { Name = "Well" }
                },
                PatternList = new List<PatternComponent>()
                {
                    new PatternComponent() { Name = "Alerts" },
                    new PatternComponent() { Name = "Breadcrumbs" },
                    new PatternComponent() { Name = "Buttons-Advanced" },
                    new PatternComponent() { Name = "Dropdowns" },
                    new PatternComponent() { Name = "Forms" },
                    new PatternComponent() { Name = "Hero" },
                    new PatternComponent() { Name = "List-Groups" },
                    new PatternComponent() { Name = "Media-Object" },
                    new PatternComponent() { Name = "Navbar" },
                    new PatternComponent() { Name = "Navs" },
                    new PatternComponent() { Name = "Page-Header" },
                    new PatternComponent() { Name = "Pager" },
                    new PatternComponent() { Name = "Pagination" },
                    new PatternComponent() { Name = "Panels" },
                    new PatternComponent() { Name = "Thumbnails" }
                }
            };

            return View(componentGroup);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}