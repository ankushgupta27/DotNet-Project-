using System;
using System.Collections.Generic;

namespace BlogMgmt.Data.Entities;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public int? MobileNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsEmailVerified { get; set; }

    public int RoleId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Blog> BlogCreatedByNavigations { get; } = new List<Blog>();

    public virtual ICollection<Blog> BlogUpdatedByNavigations { get; } = new List<Blog>();

    public virtual ICollection<Category> CategoryCreatedByNavigations { get; } = new List<Category>();

    public virtual ICollection<Category> CategoryUpdatedByNavigations { get; } = new List<Category>();

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<User> InverseCreatedByNavigation { get; } = new List<User>();

    public virtual ICollection<User> InverseUpdatedByNavigation { get; } = new List<User>();

    public virtual Role Role { get; set; } = null!;

    public virtual State? State { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }
}
