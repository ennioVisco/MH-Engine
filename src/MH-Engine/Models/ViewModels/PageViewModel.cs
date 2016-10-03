using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.ViewModels
{
    public class PageViewModel
    {
        public string Title { get; set; }

        public PageViewModel(string title)
        {
            this.Title = title;
        }
    }
}

