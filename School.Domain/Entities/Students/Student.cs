using School.Domain.Commons;
using School.Domain.Entities.Classes;

namespace School.Domain.Entities.Students;
public class Student : Auditable
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public int ClassId { get; set; }
    public Class Class { get; set; }
}
