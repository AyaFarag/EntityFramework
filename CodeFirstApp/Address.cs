using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    [Table("ContentAdress")]
    public class Address
    {
        public int Id { get; set; }

        [Column("ADContent")]
        public string Content { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        //[NotMapped]
        public string Country { get; set; }

        public int Student_id { get; set; }
        [ForeignKey("Student_id")]
        public virtual Student Student { get; set; }
    }
}
