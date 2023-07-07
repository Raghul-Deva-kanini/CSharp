﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rel2CodeFirst.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpNo { get; set; }
        [Required]
        public string EmpName { get; set; }=string.Empty;
       
        public int? deptno { get; set; }
        public virtual Dept? Deptnav { get; set; }


    }
}
