using PurpleBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurpleBuzz.ViewModels
{
    public class HomeVM
    {
        public Work MyProperty { get; set; }
        public List<Work> Works { get; internal set; }
        public List<slider> Sliders { get; internal set; }
    }
}
