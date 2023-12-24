using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormService.Infrastructure.Context.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; } 
}
