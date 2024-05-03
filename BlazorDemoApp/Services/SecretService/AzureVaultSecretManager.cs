using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.Text.Json;


namespace BlazorDemoApp.Services.SecretService
{
    public class AzureVaultSecretManager : ISecretManager
    {
        SecretClient _secretClient;

        public AzureVaultSecretManager(IConfiguration configuration) 
        {
            string vaultUrl = configuration["AzureVaultUri"] ?? string.Empty;

            // Authenticate to Azure using the default credentials
            var credential = new DefaultAzureCredential();
            // Create a new Key Vault client
            _secretClient = new SecretClient(new Uri(vaultUrl), credential);

        }
        public string GetSecret(string secretName)
        {
            KeyVaultSecret secret = _secretClient.GetSecret(secretName);

            // Access the value of the secret
            var secretValue = secret.Value;

            return secretValue;
        }

        public TResult GetSecret<TResult>(string secretName)
        {
            string secretJson = GetSecret(secretName);
            return JsonSerializer.Deserialize<TResult>(secretJson);
        }
    }
}
