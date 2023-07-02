using NPS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Api.Models
{
    public record BaseModel : IBaseModel
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }

        public byte[] LastModified { get; set; } = new byte[0];
    }
}
