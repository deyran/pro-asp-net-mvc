using System;
using System.Text;
using System.Web.Mvc;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.HtmlHelpers
{
    /*
    EE ADDING PAGINATION
	    Adding the HTML helper method
		    Listing 7-18. The contents of the PagingHelpers.cs file
     */
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
                                              PagingInfo pagingInfo,
                                              Func<int, string> pageUrl)
        {
            string resultAux;
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                resultAux = tag.ToString();
                if (i < pagingInfo.TotalPages) resultAux += "&nbsp;-&nbsp;";

                tag.AddCssClass("btn btn-primary");
                result.Append(resultAux);
            }

            return MvcHtmlString.Create(result.ToString());
        }
    }
}