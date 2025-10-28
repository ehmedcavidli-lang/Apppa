using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRACRICE.Models
{
    public abstract class BaseEntitie
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
