using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class HtmlEncodedViewModel
    {
        public string Source { get; set; }
        public string Output { get; set; }

        public HtmlEncodedViewModel(string source)
        {
            this.Source = source;
            this.Output = HttpUtility.HtmlEncode(source);
        }
    }
}