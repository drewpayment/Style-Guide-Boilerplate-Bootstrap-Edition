using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FDStyleGuide.Models
{
    public class Component
    {
        public List<BaseComponent> BaseList { get; set; }
        public List<PatternComponent> PatternList { get; set; }
    }


    public class BaseComponent
    {
        public string Name { get; set; }
    }


    public class PatternComponent
    {
        public string Name { get; set; }
    }
}