using ManageService.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Domain.ManageService
{
    [Table("status", Schema = "manageservices")]
    public  class Status : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}
