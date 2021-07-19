using System.ComponentModel.DataAnnotations;

namespace glistServer.Models
{
  public class Car
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int yr { get; set; }
  }
}