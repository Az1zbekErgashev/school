using School.Domain.Models.Class;
using School.Service.DTOs.Class;

namespace School.Service.Interfaces.Class
{
    public interface IClassService
    {
        ValueTask<bool> DeleteAsync(int id);
        ValueTask<List<ClassModel>> GetAsync();
        ValueTask<ClassModel> GetById(int id);
        ValueTask<ClassModel> CreateAsync(ClassForCreationDTO @dto);
        ValueTask<ClassModel> UpdateAsync(int id, ClassForCreationDTO @dto);
    }
}
