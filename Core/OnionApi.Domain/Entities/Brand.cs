using OnionApi.Domain.Common;

namespace OnionApi.Domain.Entities;

public class Brand : EntityBase
{
    public Brand()
    {
        
    }
    public Brand(string name)
    {
        Name = name;
    }
    public required string Name { get; set; }
}
