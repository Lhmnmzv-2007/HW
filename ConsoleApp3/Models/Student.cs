using HW.Enums;
using HW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Models;

public class Students : Entity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int SchoolNumer { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Book> Books { get; set; }
}
