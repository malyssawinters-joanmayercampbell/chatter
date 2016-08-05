using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Chat
    {
        //properties
        [Key]
        public int ChatID { get; set; }
        [MaxLength (149)]
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }

        //navigation properties
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
