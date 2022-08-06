using ManageService.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Domain.ManageService
{
    [Table("clientadress", Schema = "manageservices")]
    public class ClientAdress : BaseEntity
    {
        [Column("adress")]
        public string Adress { get; set; }
        [Column("idcliente")]
        public int idcliente { get; set; }
        [Column("isactive")]
        public bool IsActive { get; set; }

        [ForeignKey("idcliente")]
        public virtual Client? Client { get; set; }

    }
}
