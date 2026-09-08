using HW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models;

public class BookType : Entity
{
    public string BookType { get; set; }
    public ICollection<Book> Books { get; set; }
}
