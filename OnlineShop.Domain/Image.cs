using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public byte[] Data { get; set; }
    }
}
