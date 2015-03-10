//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectTracker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Role
    {
        public Role()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        [Display(Name = "Role ID")]
        public int Role_Id { get; set; }

        public string Title { get; set; }

        // Navigation property
        public virtual ICollection<Employee> Employees { get; set; }

        // For maintainability, less hard-coding
        public enum Enum
        {
            Admin = 0, Contributor, Ambassador, Mentor
        }

        public bool Is(Enum role)
        {
            return (Role_Id == (int)role);
        }
    }
}