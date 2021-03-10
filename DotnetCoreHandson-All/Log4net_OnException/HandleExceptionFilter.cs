using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Log4net_OnException
{
    public class HandleExceptionFilter : IExceptionFilter
    {
        private readonly ILoggerManager logger;
        public HandleExceptionFilter()
        {
            this.logger = new LoggerManager();
        }
        public  void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomError" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(
                modelMetadata, context.ModelState);

            result.ViewData.Add("HandleException",
                context.Exception.ToString());

            result.ViewData.Add("source",
                context.Exception.Source);

            result.ViewData.Add("Message",
                context.Exception.Message);

            context.Result = result;
            logger.LogInformation(context.Exception.Message);
            context.ExceptionHandled = true;
        }
    }
}
