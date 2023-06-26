using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Logic.Models
{
    internal record Project : BaseModel
    {
        public string Name { get; set; } = string.Empty;
    }
}
