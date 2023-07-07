using Microsoft.Identity.Client;

namespace Rel2.models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empno { get; set; }
        [Required]

        public string Empname { get; set; } = string.Empty;

        public int? Deptno { get; set; }

        public virtual Dept? DeptnoRef { get ; set; }
    }
}
