// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using static webUi.Program;

// namespace webUi.Extensions
// {
//     public static class MigrationManager
//     {
//         public static IHost MigrateDatabase(this IHost host)
//         {
//             using (var scope = host.Services.CreateScope())
//             {
//                 using (var TorServicesContext = scope.ServiceProvider.GetRequiredService<TorServicesContext>())
//                 {
//                     try
//                     {
//                         TorServicesContext.Database.Migrate();
//                     }
//                     catch (System.Exception)
//                     {

//                         throw;
//                     }
//                 }
//             }
//             return host;
//         }
//     }
// }