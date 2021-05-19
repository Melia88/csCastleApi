using System.ComponentModel.DataAnnotations;

namespace csCastleApi.Models
{
  public class Castle
  {
    public int ID { get; set; }
    [Required]
    public string Name { get; set; }
    public int KnightCount { get; set; }
    public string Location { get; set; }
    public bool HasPrincess { get; set; }
    public bool HasDragon { get; set; }
  }
}