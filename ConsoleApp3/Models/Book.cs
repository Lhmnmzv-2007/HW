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
    public Authors Author { get; set; }
    public BookTypes Type { get; set; }
    public ICollection<Students> Students { get; set; }
}