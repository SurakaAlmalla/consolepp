namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();
            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello !");
            //    });

            //    endpoints.MapGet("/Home", async contect =>
            //    {
            //        await contect.Response.WriteAsync("Hello Home!");
            //    });

            //    endpoints.MapGet("/Product/{ID:int?}", async contect =>
            //    {
            //        var idData = contect.Request.RouteValues["Id"];
            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(contect.Request.RouteValues["Id"]);
            //            await contect.Response.WriteAsync($"Hello ID => {id}");
            //        }
            //        else

            //            await contect.Response.WriteAsync("Hello ID ");


            //    });

            //    endpoints.MapGet("/Book/{ID?}/{author:alpha}", async contect =>
            //    {

            //        int id = Convert.ToInt32(contect.Request.RouteValues["Id"]);
            //        string author = contect.Request.RouteValues["author"].ToString();
            //        await contect.Response.WriteAsync($"Hello ID => {id} and author {author}");
            //    });
            //});

            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Hello Error 404!");
            //});

            #endregion

            app.MapControllerRoute(
                name:"default",
                pattern: "/{controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                                         );


            app.Run();
        }
    }
}
