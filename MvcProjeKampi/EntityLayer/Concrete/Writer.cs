using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(25)]
        public string WriterName { get; set; }
        [StringLength(25)]
        public string WriterSurName { get; set; }
        [StringLength(120)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(25)]
        public string WriterPassword { get; set; }

        public ICollection<Content> Contents { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
