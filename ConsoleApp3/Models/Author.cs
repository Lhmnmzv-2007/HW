using HW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models;

public class Author : Entity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public ICollection<Book> Books { get; set; }
}
