using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblUserType
{
    public byte UserTypeId { get; set; }

    public string UserTypeName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int UpdatedBy { get; set; }

    public TimeOnly? AllowedStartTime { get; set; }

    public TimeOnly? AllowedEndTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
