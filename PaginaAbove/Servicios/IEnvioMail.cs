using PaginaAbove.Models;
using System.Threading.Tasks;

namespace PaginaAbove.Servicios
{
    public interface IEnvioMail
    {
        Task SendEmailAsync(EnvioMail mailRequest);
    }
}
