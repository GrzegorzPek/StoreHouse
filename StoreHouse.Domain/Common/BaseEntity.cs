using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHouse.Domain.Common
{
    public class BaseEntity:AuditTableModel
    {
        public int Id { get; set; }
    }
}
