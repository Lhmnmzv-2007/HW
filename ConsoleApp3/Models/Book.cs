using HW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models;

public class Books : Entity
{
    public string Name { get; set; }
    public int PageCount { get; set; }
    public int AuthorId { get; set; }
    public int BookTypeId { get; set; }
    public Author Author { get; set; }
    public BookType BookType { get; set; }
    public ICollection<Student> Students { get; set; }
}
