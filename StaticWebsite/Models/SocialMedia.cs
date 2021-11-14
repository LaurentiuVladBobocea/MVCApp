using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaticWebsite.Models
{
    public class SocialMedia
    {
        [Required]
        //[MaxLength(255)]
        public string Facebook { get; set; }
        [Required] 
        public string Google { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public int EmployeeId { get; set; }
        public int SocialMediaId { get; set; }
    }
}