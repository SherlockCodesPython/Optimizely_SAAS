using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;


namespace PrometheusBackend.Models.Pages
{

    [ContentType(
        GUID = "dc70e012-9436-4b65-bae2-52ee62e539a3", 
        DisplayName = "Home Page")]
    public class HomePage : PageData
    {

        [Display(Name = "Topic Heading", Description = "Enter the topic heading for the home page",Order = 10)]
        [Required]
        public virtual string TopicHeading { get; set; } = string.Empty;

        [Display(Name = "Description", Description = "Enter a brief description for the home page",Order = 20)]
        [Required]
        public virtual string Description { get; set; } = string.Empty;

        [Display(Name = "Details", Description = "Enter detailed information for the home page",Order = 30)]
        [Required]
        public virtual XhtmlString? Details { get; set; }

    }
}
