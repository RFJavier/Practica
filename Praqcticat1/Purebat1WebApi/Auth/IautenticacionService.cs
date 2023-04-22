using Entidadesdenegocio;

namespace Purebat1WebApi.Auth
{
    public interface IautenticacionService
    {
        string Authenticate(Usuario pusuario);
    }
}
