using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMAWS_T2203E_NgThaiNguyen.Models
{

    [Table("Projects")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Project Name is required.")]
        [StringLength(150, MinimumLength = 2)]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Project Start Date is required.")]
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

    }
}
