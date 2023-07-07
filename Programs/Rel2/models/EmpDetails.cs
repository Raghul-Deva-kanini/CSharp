namespace Rel2.models
{
    public class EmpDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int empno { get; set; }
        [Required]
        public long aadharno { get; set; }
        [Required]
        public string panno { get; set; } = string.Empty;
    }
}
