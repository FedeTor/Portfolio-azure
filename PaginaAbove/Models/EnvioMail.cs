using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PaginaAbove.Models
{
    public class EnvioMail
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }

    }

    public class RequestEnvioMail
    {
        public string Nombre { get; set; }  
        public string Email { get; set; }  
        public int Celular { get; set; }  
        public string mensaje { get; set; }  
    }
}
