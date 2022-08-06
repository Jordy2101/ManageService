using ManageService.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.Dtos
{
    public class TypeServiceDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
