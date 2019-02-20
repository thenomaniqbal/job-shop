using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.EnterpriseServices.Internal;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JobShop.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name"), Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        [StringLength(1)]
        public string Gender { get; set; }

        //public byte[] UserPhoto { get; set; }
        public virtual ICollection<Job> job { get; set; }
        [Display(Name = "CompanyName")]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Display(Name = "CompanyId")]
        [StringLength(100)]
        public string CompanyId { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public byte[] ProfilePicture { get; set; }


    }
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
          : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        //public DbSet<Job> JobSeekers { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Employer> employers { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogViewModel> BlogViewModels { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public System.Data.Entity.DbSet<JobShop.Models.FileUploadDBModel> FileUploadDBModels { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public System.Data.Entity.DbSet<JobShop.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<JobShop.Models.Job> Jobs { get; set; }


        public System.Data.Entity.DbSet<JobShop.Models.ApplyForJob> ApplyForJobs { get; set; }

        public System.Data.Entity.DbSet<JobShop.Models.EditProfileViewModel> EditProfileViewModels { get; set; }

    }
}
