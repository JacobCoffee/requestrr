using System.ComponentModel.DataAnnotations;
using Requestrr.WebApi.RequestrrBot.DownloadClients;

namespace Requestrr.WebApi.Controllers.DownloadClients.Ombi
{
    public class OmbiSettings
    {
        [Required]
        public string Hostname { get; set; }
        [Required]
        public int Port { get; set; }
        [Required]
        public string ApiKey { get; set; }
        public string ApiUsername { get; set; }
        [Required]
        public string BaseUrl { get; set; }
        public bool UseSSL { get; set; }
        [Required]
        public string Version { get; set; }
    }
}
