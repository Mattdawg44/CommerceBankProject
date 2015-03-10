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
    
    public partial class Status
    {
        public Status()
        {
            this.Projects = new HashSet<Project>();
        }
        
        [Required,
         Display(Name="Status ID")]
        public int Status_Id { get; set; }

        [Required,
         StringLength(20)]
        public string Name { get; set; }

        // Navigation property
        public virtual ICollection<Project> Projects { get; set; }

        // For maintainability, less hard-coding
        public enum Enum
        {
            Submitted = 0, Assigned, Complete, Intern, Production, Archived
        }

        public bool Is(Enum status)
        {
            return Status_Id == (int)status;
        }
    }
}