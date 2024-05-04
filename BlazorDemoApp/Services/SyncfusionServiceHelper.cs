using BlazorDemoApp.Services.SecretService;

namespace BlazorDemoApp.Services
{
    public static class SyncfusionServiceHelpers
    {
        public static void RegisterSyncfusionLicense(this WebApplication application)
        {
            try
            {
                var secretManager = application.Services.GetRequiredService<ISecretManager>();
                var licenceKey = secretManager.GetSecret("syncfusion-licence-key") ?? string.Empty;

                if (!string.IsNullOrEmpty(licenceKey))
                {
                    Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(secretManager.GetSecret("syncfusion-licence-key"));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
