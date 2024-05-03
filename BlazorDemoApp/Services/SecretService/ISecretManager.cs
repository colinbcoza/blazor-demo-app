namespace BlazorDemoApp.Services.SecretService
{
    public interface ISecretManager
    {
        string GetSecret(string secretName);
        TResult GetSecret<TResult>(string secretName);
    }
}
