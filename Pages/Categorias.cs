
using System.ComponentModel.DataAnnotations;

namespace PATENT_web.Pages;

public class Categorias
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string autor { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreatedDataTime { get; set; } = DateTime.Now;

}
