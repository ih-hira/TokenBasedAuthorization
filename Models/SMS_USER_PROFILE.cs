using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchAntenna.Models
{
    public class SMS_USER_PROFILE
    {
        [Key]
        [Required]
        public string user_id { get; set; }
        public string user_nm { get; set; }
        public string user_descrip { get; set; }
        public string home_branch_id { get; set; }
    }
}
