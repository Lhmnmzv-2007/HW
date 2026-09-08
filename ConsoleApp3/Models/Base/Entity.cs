using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Enums;

namespace HW.Models.Base;

public abstract class Entity
{
    public int Id { get; set; }
    public DataStatus DataStatus { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    protected Entity()
    {
        CreatedDate = DateTime.Now;
    }

}
