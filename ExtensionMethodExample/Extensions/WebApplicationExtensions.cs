using System.Runtime.CompilerServices;

namespace ExtensionMethodExample.Extensions
{
    public static class WebApplicationExtensions
    {
        public static IApplicationBuilder RegisterCustomLogger(this WebApplication app)
        {
            //all of the custom code to build your custom logger
            //app.Logger = somecustomlogger;
            return app;
        }
    }
}
