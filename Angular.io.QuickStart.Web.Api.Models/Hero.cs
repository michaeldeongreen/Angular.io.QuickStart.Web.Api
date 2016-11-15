using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Models
{
    public class Hero
    {
        [Key]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        [Column("HeroId")]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
    }
}
