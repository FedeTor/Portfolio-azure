using PaginaAbove.Models;
using System.Threading.Tasks;

namespace PaginaAbove.Servicios
{
    public interface IServicioEnviarDatos
    {
        Task<EnvioDatos> EnviarDatosAsync(EnvioDatos enviodatos);
        public int EnvioDatos(EnvioDatos enviodatos);
    }


}
