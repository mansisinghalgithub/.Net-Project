using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Project
{
    [Key]
    [Column("ProjNo", TypeName = "int")]
    [Required(ErrorMessage = "ProjNo is required")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ProjNo { get; set; }

    [Column("ProjName", TypeName = "varchar(50)")]
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "ProjName cannot be longer than 50 characters")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "ProjName can only contain letters and spaces")]
    public string ProjName { get; set; } = null!;

    [Column("StartDate", TypeName = "date")]
    [Required(ErrorMessage = "Date is required")]
    public DateTime StartDate { get; set; }

    [Column("EndDate", TypeName = "date")]
    [Required(ErrorMessage = "Date is required")]
    public DateTime EndDate { get; set; }
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}


