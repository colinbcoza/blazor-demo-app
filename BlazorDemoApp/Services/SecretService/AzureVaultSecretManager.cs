namespace BlazorDemoApp.Services.SecretService
{
    public class AzureVaultSecretManager : ISecretManager
    {
        public string GetSecret(string secretName)
        {
            throw new NotImplementedException();
        }

        public TResult GetSecret<TResult>(string secretName)
        {
            throw new NotImplementedException();
        }
    }
}
