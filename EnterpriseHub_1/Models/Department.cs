using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


    public partial class Department
    {
        [Key]
        [Column("DeptNo", TypeName = "int")]
        [Required(ErrorMessage = "DeptNo is required")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptNo { get; set; }

        [Column("DeptName", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "DeptName cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "DeptName can only contain letters and spaces")]
    public string DeptName { get; set; } = null!;

        [Column("DeptHead", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Head is required")]
        [StringLength(50, ErrorMessage = "Head cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Head can only contain letters and spaces")]
    public string DeptHead { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

