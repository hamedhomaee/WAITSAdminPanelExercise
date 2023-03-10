using System.ComponentModel.DataAnnotations;

namespace WAITSAdminPanelExercise.Entities;

public class AppUsers
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(30)]
    public string? LicenseType { get; set; }
}