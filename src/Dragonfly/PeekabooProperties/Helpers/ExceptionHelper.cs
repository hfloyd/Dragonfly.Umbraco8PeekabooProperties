namespace Dragonfly.PeekabooProperties.Helpers
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using Umbraco.Core.Composing;

    public class ExceptionHelper
    {

        public static string GetExceptionMessage(Exception ex, bool includeStackTrace = true)
        {
            StringBuilder exceptionMessage = new StringBuilder();
            exceptionMessage.AppendLine(ex.Message);
            if (ex.InnerException != null)
            {
                exceptionMessage.AppendLine(ex.InnerException.Message);
            }
            StackTrace stackTrace = new StackTrace(true);
            exceptionMessage.AppendLine(stackTrace.ToString());
            return exceptionMessage.ToString();
        }

        public static void LogExceptionMessage(Type callingType, Exception ex, bool includeStackTrace = true)
        {
            if (callingType == null)
            {
                callingType = typeof(ExceptionHelper);
            }
            Current.Logger.Error(callingType, GetExceptionMessage(ex, includeStackTrace), ex);
        }

    }
}