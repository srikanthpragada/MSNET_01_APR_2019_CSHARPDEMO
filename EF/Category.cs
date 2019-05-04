using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    //[Table("categories")]
    class Category
    {
        [Column("CatCode")]
        [Key]
        public string Code { get; set; }

        [Column("CatDesc")]
        public string Description { get; set; }
    }
}
