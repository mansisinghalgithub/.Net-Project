using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


    public partial class Employee
    {
        [Key]
        [Column("EmpNo", TypeName = "int")]
        [Required(ErrorMessage = "EmpNo is required")]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpNo { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "EmpName is required")]
        [StringLength(50, ErrorMessage = "EmpName cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "EmpName can only contain letters and spaces")]
    public string Name { get; set; } = null!;

        [Column("Email", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Column("Basic", TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Basic is required")]
        public decimal Basic { get; set; }

        [Column("DeptNo", TypeName = "int")]
        [Required(ErrorMessage = "Select from Drop-Down")]
        public int DeptNo { get; set; }

        [Column("PosNo", TypeName = "int")]
        [Required(ErrorMessage = "Select from Drop-Down")]
        public int PosNo { get; set; }

        [Column("ProjNo", TypeName = "int")]
        [Required(ErrorMessage = "Select from Drop-Down")]
        public int ProjNo { get; set; }


        [ForeignKey("DeptNo")]
        public virtual Department? DeptNoNavigation { get; set; } = null!;

        [ForeignKey("PosNo")]
        public virtual Position? PosNoNavigation { get; set; } = null!;

        [ForeignKey("ProjNo")]
        public virtual Project? ProjNoNavigation { get; set; } = null!;
    }

