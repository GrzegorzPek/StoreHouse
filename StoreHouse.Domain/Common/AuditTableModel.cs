using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHouse.Domain.Common
{
    public class AuditTableModel
    {
        public int CreateById { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int ModfiedById { get; set; }
        public DateTime? ModfiedDateTime { get; set; }
    }
}
