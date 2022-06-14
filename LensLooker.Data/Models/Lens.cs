using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LensLooker.Data.Models;

[Index(nameof(Name), nameof(LensFamilyId), IsUnique = true)]
public class Lens
{
    public int Id { get; set; }

    public string Name { get; set; }
    public virtual List<Photo> Photos { get; set; }
    public int? LensFamilyId { get; set; }
    public virtual LensFamily? LensFamily { get; set; }

    [ForeignKey("AliasOf")] public int? AliasOfId { get; set; }

    public virtual Lens? AliasOf { get; set; }
}