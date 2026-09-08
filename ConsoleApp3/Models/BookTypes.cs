using HW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models;

public class BookTypes : Entity
{
    public string Type { get; set; }
    public ICollection<Book> Books { get; set; }
}
