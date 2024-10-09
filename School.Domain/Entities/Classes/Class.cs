using School.Domain.Commons;
using School.Domain.Entities.Students;

namespace School.Domain.Entities.Classes;

public class Class : Auditable
{
    public string Name { get; set; }
    public ICollection<Student> Students { get; set; }
}
