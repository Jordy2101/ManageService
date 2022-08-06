using ManageService.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Domain.ManageService
{
    [Table("service", Schema = "manageservices")]
    public class Service : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("descripcion")]
        public string Description { get; set; }
        [Column("idcliente")]
        public int idcliente { get; set; }
        [Column("idstatus")]
        public int idstatus { get; set; }
        [Column("idtypeservice")]
        public int idtypeservice { get; set; }
        [Column("idadress")]
        public int idadress { get; set; }

        [ForeignKey("idcliente")]
        public virtual Client? Client { get; set; }
        [ForeignKey("idstatus")]
        public virtual Status? Status { get; set; }
        [ForeignKey("idtypeservice")]
        public virtual TypeService? TypeService { get; set; }
        [ForeignKey("idadress")]
        public virtual ClientAdress? ClientAdress { get; set; }
    }
}
