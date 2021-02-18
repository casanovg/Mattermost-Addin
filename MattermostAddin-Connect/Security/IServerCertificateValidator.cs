namespace MattermostAddinConnect.Security
{
    public interface IServerCertificateValidator
    {
        void EnableValidation();
        void DisableValidation();
    }
}
