using ManageService.Common.Filter.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Common.Filter
{
    public class ServiceFilter : BaseFilter
    {
        public string? keyword { get; set; }
    }
}
