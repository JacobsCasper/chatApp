using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace chatApp.Models
{
    public class MessageFileModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public IFormFile File { get; set; }
        public DateTime When { get; set; }
        public string UserId { get; set; }
        public virtual AppUser Sender { get; set; }

        public MessageFileModel()
        {
            When = DateTime.Now;
        }
    }
}
