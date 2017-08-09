using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Gsys.Mvc.Helpers
{
    public static class UtilHelper
    {
        //OLD
        //public static MvcHtmlString Pagination<TModel>(this HtmlHelper<TModel> helper, string url, int pagAtual,
        //    int qtdePag, string formId = null, string divLocation = null, bool beginEnd = true)
        //{
        //    if (qtdePag < 1)
        //        return null;

        //    var nav = new TagBuilder("nav");
        //    nav.AddCssClass("text-center");

        //    var ul = new TagBuilder("ul");
        //    ul.AddCssClass("pagination");

        //    var liBegin = new TagBuilder("li")
        //    {
        //        InnerHtml = formId != null && divLocation != null
        //            ? (pagAtual != 1
        //                ? $"<a href=\"#\" onclick=\"AjaxSubmitForm('{formId}', '#{divLocation}', '{url}', '{1}')\" " +
        //                  $"aria-label=\"Previous\"><span aria-hidden=\"true\">&laquo;</span></a>"
        //                : "<a aria-label=\"Previous\"><span aria-hidden=\"true\">&laquo;</span></a>")
        //            : formId != null
        //                ? (pagAtual != 1
        //                    ? $"<a href=\"#\" onclick=\"SubmitForm('{formId}', '{url}', '{1}')\" " +
        //                      $"aria-label=\"Previous\"><span aria-hidden=\"true\">&laquo;</span></a>"
        //                    : "<a aria-label=\"Previous\"><span aria-hidden=\"true\">&laquo;</span></a>")
        //                : (pagAtual != 1
        //                    ? $"<a href=\"{url}?idPag={1}\" aria-label=\"Previous\"><span aria-hidden=\"true\">&laquo;</span></a>"
        //                    : "<a aria-label=\"Previous\" class=\"disabled\"><span aria-hidden=\"true\">&laquo;</span></a>")
        //    };

        //    var liPrevious = new TagBuilder("li")
        //    {
        //        InnerHtml = formId != null && divLocation != null
        //            ? (pagAtual != 1
        //                ? $"<a href=\"#\" onclick=\"AjaxSubmitForm('{formId}', '#{divLocation}', '{url}', '{(pagAtual - 1)}')\" " +
        //                  $"aria-label=\"Previous\"><span aria-hidden=\"true\">&lsaquo;</span></a>"
        //                : "<a aria-label=\"Previous\"><span aria-hidden=\"true\">&lsaquo;</span></a>")
        //            : formId != null
        //                ? (pagAtual != 1
        //                    ? $"<a href=\"#\" onclick=\"SubmitForm('{formId}', '{url}', '{(pagAtual - 1)}')\" " +
        //                      $"aria-label=\"Previous\"><span aria-hidden=\"true\">&lsaquo;</span></a>"
        //                    : "<a aria-label=\"Previous\"><span aria-hidden=\"true\">&lsaquo;</span></a>")
        //                : (pagAtual != 1
        //                    ? $"<a href=\"{url}?idPag={(pagAtual - 1)}\" aria-label=\"Previous\"><span aria-hidden=\"true\">&lsaquo;</span></a>"
        //                    : "<a aria-label=\"Previous\" class=\"disabled\"><span aria-hidden=\"true\">&lsaquo;</span></a>")
        //    };

        //    if (pagAtual == 1)
        //    {
        //        liBegin.AddCssClass("disabled");
        //        liPrevious.AddCssClass("disabled");
        //    }

        //    var liList = (beginEnd ? liBegin.ToString(TagRenderMode.Normal) : null) +
        //                 liPrevious.ToString(TagRenderMode.Normal);

        //    int maxPag = qtdePag > 5 ? 5 : qtdePag;

        //    for (int i = 0; i < maxPag; i++)
        //    {
        //        int numPag;
        //        if (maxPag < 5)
        //        {
        //            numPag = i + 1;
        //        }
        //        else if (pagAtual < 3 || (pagAtual + 2) > qtdePag)
        //        {
        //            switch ((qtdePag - pagAtual))
        //            {
        //                case 0:
        //                    numPag = (pagAtual - 4) + i;
        //                    break;
        //                case 1:
        //                    numPag = (pagAtual - 3) + i;
        //                    break;
        //                case 2:
        //                    numPag = (pagAtual - 2) + i;
        //                    break;
        //                case 3:
        //                    numPag = (pagAtual - 1) + i;
        //                    break;
        //                default:
        //                    numPag = pagAtual + i;
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            switch (i)
        //            {
        //                case 0:
        //                    numPag = pagAtual - 2;
        //                    break;
        //                case 1:
        //                    numPag = pagAtual - 1;
        //                    break;
        //                case 2:
        //                    numPag = pagAtual;
        //                    break;
        //                case 3:
        //                    numPag = pagAtual + 1;
        //                    break;
        //                case 4:
        //                    numPag = pagAtual + 2;
        //                    break;
        //                default:
        //                    numPag = 0;
        //                    break;
        //            }
        //        }

        //        var li = new TagBuilder("li")
        //        {
        //            InnerHtml = formId != null && divLocation != null
        //                ? $"<a href=\"#\" onclick=\"AjaxSubmitForm('{formId}', '#{divLocation}', '{url}', '{numPag}')\">{numPag} " +
        //                  $"<span class=\"sr-only\">(current)</span></a>"
        //                : formId != null
        //                    ? $"<a href=\"#\" onclick=\"SubmitForm('{formId}', '{url}', '{numPag}')\">{numPag} " +
        //                      $"<span class=\"sr-only\">(current)</span></a>"
        //                    : $"<a href=\"{url}?idPag={numPag}\">{numPag} <span class=\"sr-only\">(current)</span></a>"
        //        };

        //        if (numPag == pagAtual)
        //            li.AddCssClass("active");

        //        liList = liList + li.ToString(TagRenderMode.Normal);
        //    }

        //    var liNext = new TagBuilder("li")
        //    {
        //        InnerHtml = formId != null && divLocation != null
        //            ? (pagAtual != qtdePag
        //                ? $"<a href=\"#\" onclick=\"AjaxSubmitForm('{formId}', '#{divLocation}', '{url}', '{(pagAtual + 1)}')\" " +
        //                  $"aria-label=\"Next\"><span aria-hidden=\"true\">&rsaquo;</span></a>"
        //                : "<a aria-label=\"Next\"><span aria-hidden=\"true\">&rsaquo;</span></a>")
        //            : formId != null
        //                ? (pagAtual != qtdePag
        //                    ? $"<a href=\"#\" onclick=\"SubmitForm('{formId}', '{url}', '{(pagAtual + 1)}')\" " +
        //                      $"aria-label=\"Next\"><span aria-hidden=\"true\">&rsaquo;</span></a>"
        //                    : "<a aria-label=\"Next\"><span aria-hidden=\"true\">&rsaquo;</span></a>")
        //                : (qtdePag != pagAtual
        //                    ? $"<a href=\"{url}?idPag={(pagAtual + 1)}\" aria-label=\"Next\"><span aria-hidden=\"true\">&rsaquo;</span></a>"
        //                    : "<a aria-label=\"Next\" class=\"disabled\"><span aria-hidden=\"true\">&rsaquo;</span></a>")
        //    };

        //    var liEnd = new TagBuilder("li")
        //    {
        //        InnerHtml = formId != null && divLocation != null
        //            ? (pagAtual != qtdePag
        //                ? $"<a href=\"#\" onclick=\"AjaxSubmitForm('{formId}', '#{divLocation}', '{url}', '{qtdePag}')\" " +
        //                  $"aria-label=\"Next\"><span aria-hidden=\"true\">&raquo;</span></a>"
        //                : "<a aria-label=\"Next\"><span aria-hidden=\"true\">&raquo;</span></a>")
        //            : formId != null
        //                ? (pagAtual != qtdePag
        //                    ? $"<a href=\"#\" onclick=\"SubmitForm('{formId}', '{url}', '{qtdePag}')\" " +
        //                      $"aria-label=\"Next\"><span aria-hidden=\"true\">&raquo;</span></a>"
        //                    : "<a aria-label=\"Next\"><span aria-hidden=\"true\">&raquo;</span></a>")
        //                : (qtdePag != pagAtual
        //                    ? $"<a href=\"{url}?idPag={qtdePag}\" aria-label=\"Next\"><span aria-hidden=\"true\">&raquo;</span></a>"
        //                    : "<a aria-label=\"Next\" class=\"disabled\"><span aria-hidden=\"true\">&raquo;</span></a>")
        //    };

        //    if (pagAtual == qtdePag)
        //    {
        //        liNext.AddCssClass("disabled");
        //        liEnd.AddCssClass("disabled");
        //    }

        //    ul.InnerHtml = liList + liNext.ToString(TagRenderMode.Normal) +
        //                   (beginEnd ? liEnd.ToString(TagRenderMode.Normal) : null);
        //    nav.InnerHtml = ul.ToString(TagRenderMode.Normal);

        //    return MvcHtmlString.Create(nav.ToString(TagRenderMode.Normal));
        //}
    }
}
