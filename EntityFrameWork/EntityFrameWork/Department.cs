namespace EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FIRSTnnam { get; set; }

        [StringLength(50)]
        public string LastNAme { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        public int? salary { get; set; }

        public int? DepartmentId { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
