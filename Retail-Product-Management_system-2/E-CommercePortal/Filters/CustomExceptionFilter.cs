using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommercePortal.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IModelMetadataProvider mmdp;
        public CustomExceptionFilter(IModelMetadataProvider immdp)
        {
            mmdp = immdp;
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "Error" };
            result.ViewData = new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary(mmdp, context.ModelState);
            result.ViewData.Add("ErrorMessage", context.Exception.Message);
            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
