using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace AboutNetCore.Version1_0.DefaultTemplate.Middleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseFiles(
            this IApplicationBuilder app, string root)
        {
            //In this method I can include files that are in my machine but not in repository for example
            var path = Path.Combine(root, "Files");

            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions
            {
                RequestPath = "/Files",
                FileProvider = provider
            };

            app.UseStaticFiles(options);

            return app;
        }
    }
}
