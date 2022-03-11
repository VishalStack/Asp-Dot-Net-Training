using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpersWithMVC
{
    public static class CustomClass
    {
        public static MvcHtmlString submitbtn1(this HtmlHelper helper, string value, string name)
        {
            string str = "<input type ='submit' name='" + name + "' value= '" + value + "'/>";
            return new MvcHtmlString(str);
        }
        public static MvcHtmlString Label1(this HtmlHelper helper, string content)
        {
            string lblmark = "<span><mark>" + content + "<mark><span/>";
            return new MvcHtmlString(lblmark);
        }
    }
}