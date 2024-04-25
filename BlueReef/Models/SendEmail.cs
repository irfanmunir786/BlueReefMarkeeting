using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Models
{
    public class SendEmail
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "Subject is required Please write your Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required Please write your Message")]
        public string Message { get; set; }

    }
}
