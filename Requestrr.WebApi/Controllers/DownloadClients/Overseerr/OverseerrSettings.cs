using System.ComponentModel.DataAnnotations;

namespace Requestrr.WebApi.Controllers.DownloadClients.Overseerr
{
    public class OverseerrSettings
    {
        [Required]
        public string Hostname { get; set; }
        [Required]
        public int Port { get; set; }
        [Required]
        public string ApiKey { get; set; }
        public string ApiUsername { get; set; }
        public bool UseSSL { get; set; }
        [Required]
        public string Version { get; set; }
    }
}
