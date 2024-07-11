using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

    public partial class Position
    {
        [Key]
        [Column("PosNo", TypeName = "int")]
        [Required(ErrorMessage = "PosNo is required")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PosNo { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name can only contain letters and spaces")]
    public string Name { get; set; } = null!;

        [Column("MinSalary", TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Min-Salary is required")]
        [Range(1000, double.MaxValue, ErrorMessage = "Min-Salary must be at least 1000")]
    public decimal MinSalary { get; set; }

        [Column("MaxSalary", TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Max-Salary is required")]
        [Range(0, 500000, ErrorMessage = "Max-Salary must be less than or equal to 500,000")]
    public decimal MaxSalary { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

