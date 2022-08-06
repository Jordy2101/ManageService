using ManageService.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Domain.ManageService
{
    [Table("client", Schema = "manageservices")]
    public class Client : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("age")]
        public int Age  { get; set; }
        [Column("isactive")]
        public bool IsActive { get; set; }
    }
}
