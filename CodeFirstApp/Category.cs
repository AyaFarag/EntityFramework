using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        
        [MaxLength(10)]
        public string? Name { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Category> SubCategories { get; set; }
        public int? parentId { get; set; }
        [ForeignKey("parentId")]
        [IgnoreDataMember]
        public virtual Category ParentCategory { get; set; }
    }
}
