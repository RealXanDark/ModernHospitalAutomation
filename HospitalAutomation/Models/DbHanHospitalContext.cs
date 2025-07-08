using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HospitalAutomation.Models;

public partial class DbHanHospitalContext : DbContext
{
    public DbHanHospitalContext()
    {
    }

    public DbHanHospitalContext(DbContextOptions<DbHanHospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAllergy> TblAllergies { get; set; }

    public virtual DbSet<TblAppointment> TblAppointments { get; set; }

    public virtual DbSet<TblAppointmentStatus> TblAppointmentStatuses { get; set; }

    public virtual DbSet<TblAppointmentTime> TblAppointmentTimes { get; set; }

    public virtual DbSet<TblBlacklist> TblBlacklists { get; set; }

    public virtual DbSet<TblBloodGroup> TblBloodGroups { get; set; }

    public virtual DbSet<TblChronicDisease> TblChronicDiseases { get; set; }

    public virtual DbSet<TblClinic> TblClinics { get; set; }

    public virtual DbSet<TblDistrict> TblDistricts { get; set; }

    public virtual DbSet<TblDoctor> TblDoctors { get; set; }

    public virtual DbSet<TblDoctorLog> TblDoctorLogs { get; set; }

    public virtual DbSet<TblDoctorRate> TblDoctorRates { get; set; }

    public virtual DbSet<TblEmailAccount> TblEmailAccounts { get; set; }

    public virtual DbSet<TblEmailAddress> TblEmailAddresses { get; set; }

    public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }

    public virtual DbSet<TblFailedLoginAttempt> TblFailedLoginAttempts { get; set; }

    public virtual DbSet<TblHospital> TblHospitals { get; set; }

    public virtual DbSet<TblHospitalClinic> TblHospitalClinics { get; set; }

    public virtual DbSet<TblHospitalMail> TblHospitalMails { get; set; }

    public virtual DbSet<TblHospitalRoom> TblHospitalRooms { get; set; }

    public virtual DbSet<TblIdentityNumber> TblIdentityNumbers { get; set; }

    public virtual DbSet<TblMailService> TblMailServices { get; set; }

    public virtual DbSet<TblMedication> TblMedications { get; set; }

    public virtual DbSet<TblPatient> TblPatients { get; set; }

    public virtual DbSet<TblPatientAllergy> TblPatientAllergies { get; set; }

    public virtual DbSet<TblPatientChronicDisease> TblPatientChronicDiseases { get; set; }

    public virtual DbSet<TblPhoneNumber> TblPhoneNumbers { get; set; }

    public virtual DbSet<TblPrescription> TblPrescriptions { get; set; }

    public virtual DbSet<TblProvince> TblProvinces { get; set; }

    public virtual DbSet<TblRequestType> TblRequestTypes { get; set; }

    public virtual DbSet<TblSessionToken> TblSessionTokens { get; set; }

    public virtual DbSet<TblSupportTicket> TblSupportTickets { get; set; }

    public virtual DbSet<TblTempBannedMacAddress> TblTempBannedMacAddresses { get; set; }

    public virtual DbSet<TblTest> TblTests { get; set; }

    public virtual DbSet<TblTestResult> TblTestResults { get; set; }

    public virtual DbSet<TblTitle> TblTitles { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserAccessHour> TblUserAccessHours { get; set; }

    public virtual DbSet<TblUserSessionLog> TblUserSessionLogs { get; set; }

    public virtual DbSet<TblUserType> TblUserTypes { get; set; }

    public virtual DbSet<TblVisit> TblVisits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=db_han_hospital;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAllergy>(entity =>
        {
            entity.HasKey(e => e.AllergyId).HasName("PK__tbl_alle__ACDD06924E923C3E");

            entity.ToTable("tbl_allergy");

            entity.Property(e => e.AllergyId).HasColumnName("allergy_id");
            entity.Property(e => e.AllergyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("allergy_name");
        });

        modelBuilder.Entity<TblAppointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__tbl_appo__A50828FCCE70FD79");

            entity.ToTable("tbl_appointment");

            entity.HasIndex(e => e.AppointmentId, "FK_tbl_appointment");

            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.AppointmentDate).HasColumnName("appointment_date");
            entity.Property(e => e.AppointmentTimeId).HasColumnName("appointment_time_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.AppointmentTime).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.AppointmentTimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_appointment_time");

            entity.HasOne(d => d.Clinic).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_hospital_clinic");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_doctor");

            entity.HasOne(d => d.Hospital).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_hospital");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_patient");

            entity.HasOne(d => d.Status).WithMany(p => p.TblAppointments)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_appointment_tbl_appointment_status");
        });

        modelBuilder.Entity<TblAppointmentStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__tbl_appo__3683B531C199D0E6");

            entity.ToTable("tbl_appointment_status");

            entity.HasIndex(e => e.StatusName, "UQ__tbl_appo__501B3753DFC911C3").IsUnique();

            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status_description");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<TblAppointmentTime>(entity =>
        {
            entity.HasKey(e => e.AppointmentTimeId).HasName("PK__tbl_appo__04EF2591EC10B86E");

            entity.ToTable("tbl_appointment_time");

            entity.HasIndex(e => e.AppointmentTime, "UQ__tbl_appo__FAB86914A49BBDB7").IsUnique();

            entity.Property(e => e.AppointmentTimeId).HasColumnName("appointment_time_id");
            entity.Property(e => e.AppointmentTime)
                .HasPrecision(0)
                .HasColumnName("appointment_time");
        });

        modelBuilder.Entity<TblBlacklist>(entity =>
        {
            entity.HasKey(e => e.BlacklistId).HasName("PK__tbl_blac__54FD53C3F53E32C7");

            entity.ToTable("tbl_blacklist");

            entity.Property(e => e.BlacklistId).HasColumnName("blacklist_id");
            entity.Property(e => e.AddedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("added_at");
            entity.Property(e => e.BlockType).HasColumnName("block_type");
            entity.Property(e => e.DeviceMacAddress)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("device_mac_address");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.UserIdentityNumber).HasColumnName("user_identity_number");
        });

        modelBuilder.Entity<TblBloodGroup>(entity =>
        {
            entity.HasKey(e => e.BloodGroupId);

            entity.ToTable("tbl_blood_group");

            entity.Property(e => e.BloodGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("blood_group_id");
            entity.Property(e => e.BloodGroupName)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("blood_group_name");
        });

        modelBuilder.Entity<TblChronicDisease>(entity =>
        {
            entity.HasKey(e => e.ChronicDiseaseId).HasName("PK__tbl_chro__985F112ECE33F2C2");

            entity.ToTable("tbl_chronic_disease");

            entity.Property(e => e.ChronicDiseaseId).HasColumnName("chronic_disease_id");
            entity.Property(e => e.AlertRequired).HasColumnName("alert_required");
            entity.Property(e => e.DiseaseName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("disease_name");
        });

        modelBuilder.Entity<TblClinic>(entity =>
        {
            entity.HasKey(e => e.ClinicId).HasName("PK__tbl_clin__A0C8D19B3FF9D835");

            entity.ToTable("tbl_clinic");

            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clinic_name");
        });

        modelBuilder.Entity<TblDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("tbl_district");

            entity.Property(e => e.DistrictId).HasColumnName("district_id");
            entity.Property(e => e.DistrictHasBranch)
                .HasDefaultValue(true)
                .HasColumnName("district_has_branch");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("district_name");
            entity.Property(e => e.DistrictParentId).HasColumnName("district_parent_id");
        });

        modelBuilder.Entity<TblDoctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__tbl_doct__F399356411695249");

            entity.ToTable("tbl_doctor");

            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.BloodGroupId).HasColumnName("blood_group_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EmailId).HasColumnName("email_id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.IdentityNumberId).HasColumnName("identity_number_id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsRestrictionExempt).HasColumnName("is_restriction_exempt");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");
            entity.Property(e => e.SpecialtyId).HasColumnName("specialty_id");
            entity.Property(e => e.TitleId).HasColumnName("title_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.BloodGroup).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.BloodGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_blood_group");

            entity.HasOne(d => d.Clinic).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_hospital_clinic");

            entity.HasOne(d => d.Email).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.EmailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_email_addresses");

            entity.HasOne(d => d.Hospital).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_hospital");

            entity.HasOne(d => d.IdentityNumber).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.IdentityNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_identity_numbers");

            entity.HasOne(d => d.PhoneNumber).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.PhoneNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_phone_numbers");

            entity.HasOne(d => d.Specialty).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.SpecialtyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_clinic");

            entity.HasOne(d => d.Title).WithMany(p => p.TblDoctors)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_tbl_title");
        });

        modelBuilder.Entity<TblDoctorLog>(entity =>
        {
            entity.ToTable("tbl_doctor_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityParameters).HasColumnName("activity_parameters");
            entity.Property(e => e.ActivityType)
                .IsUnicode(false)
                .HasColumnName("activity_type");
            entity.Property(e => e.Datetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<TblDoctorRate>(entity =>
        {
            entity.HasKey(e => e.RateId);

            entity.ToTable("tbl_doctor_rate");

            entity.Property(e => e.RateId).HasColumnName("rate_id");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.TotalRating)
                .HasDefaultValue(5)
                .HasColumnName("total_rating");
            entity.Property(e => e.TotalRatingCount)
                .HasDefaultValue(1)
                .HasColumnName("total_rating_count");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblDoctorRates)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_doctor_rate_tbl_doctor");
        });

        modelBuilder.Entity<TblEmailAccount>(entity =>
        {
            entity.HasKey(e => e.EmailAccountId).HasName("PK__tbl_emai__ADAFC8DE8094E360");

            entity.ToTable("tbl_email_accounts");

            entity.Property(e => e.EmailAccountId).HasColumnName("email_account_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EmailAddressId).HasColumnName("email_address_id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.EmailAddress).WithMany(p => p.TblEmailAccounts)
                .HasForeignKey(d => d.EmailAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_email_accounts_tbl_email_addresses");

            entity.HasOne(d => d.User).WithMany(p => p.TblEmailAccounts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_email_accounts_tbl_user");
        });

        modelBuilder.Entity<TblEmailAddress>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("PK__tbl_emai__3FEF8766592D02CE");

            entity.ToTable("tbl_email_addresses");

            entity.Property(e => e.EmailId).HasColumnName("email_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
        });

        modelBuilder.Entity<TblErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PK__tbl_erro__DA71E16CD97E7CCB");

            entity.ToTable("tbl_error_logs");

            entity.Property(e => e.ErrorId).HasColumnName("error_id");
            entity.Property(e => e.ErrorDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("error_date");
            entity.Property(e => e.ErrorMessage).HasColumnName("error_message");
            entity.Property(e => e.ErrorStack).HasColumnName("error_stack");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("mac_address");
        });

        modelBuilder.Entity<TblFailedLoginAttempt>(entity =>
        {
            entity.HasKey(e => e.AttemptId);

            entity.ToTable("tbl_failed_login_attempt");

            entity.Property(e => e.AttemptId).HasColumnName("attempt_id");
            entity.Property(e => e.AttemptTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("attempt_time");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("mac_address");
        });

        modelBuilder.Entity<TblHospital>(entity =>
        {
            entity.HasKey(e => e.HospitalId).HasName("PK__tbl_hosp__DFF4167FA6D91535");

            entity.ToTable("tbl_hospital");

            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.HospitalAddress)
                .IsUnicode(false)
                .HasColumnName("hospital_address");
            entity.Property(e => e.HospitalDistrictId).HasColumnName("hospital_district_id");
            entity.Property(e => e.HospitalIsActive)
                .HasDefaultValue(true)
                .HasColumnName("hospital_is_active");
            entity.Property(e => e.HospitalName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("hospital_name");
            entity.Property(e => e.HospitalPhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hospital_phone_number");
            entity.Property(e => e.HospitalProvinceId).HasColumnName("hospital_province_id");

            entity.HasOne(d => d.HospitalDistrict).WithMany(p => p.TblHospitals)
                .HasForeignKey(d => d.HospitalDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_tbl_district");

            entity.HasOne(d => d.HospitalProvince).WithMany(p => p.TblHospitals)
                .HasForeignKey(d => d.HospitalProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_tbl_province");
        });

        modelBuilder.Entity<TblHospitalClinic>(entity =>
        {
            entity.HasKey(e => e.HospitalClinicId);

            entity.ToTable("tbl_hospital_clinic");

            entity.Property(e => e.HospitalClinicId).HasColumnName("hospital_clinic_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.ClinicIsActive)
                .HasDefaultValue(true)
                .HasColumnName("clinic_is_active");
            entity.Property(e => e.ClinicPhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clinic_phone_number");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

            entity.HasOne(d => d.Clinic).WithMany(p => p.TblHospitalClinics)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_clinic_tbl_clinic");

            entity.HasOne(d => d.Hospital).WithMany(p => p.TblHospitalClinics)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_clinic_tbl_hospital");
        });

        modelBuilder.Entity<TblHospitalMail>(entity =>
        {
            entity.HasKey(e => e.MailId);

            entity.ToTable("tbl_hospital_mail");

            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("body");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.SenderId).HasColumnName("sender_id");
            entity.Property(e => e.SentDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sent_date_time");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");

            entity.HasOne(d => d.Receiver).WithMany(p => p.TblHospitalMailReceivers)
                .HasForeignKey(d => d.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_mail_tbl_email_accounts_receiver");

            entity.HasOne(d => d.Sender).WithMany(p => p.TblHospitalMailSenders)
                .HasForeignKey(d => d.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_mail_tbl_email_accounts_sender");
        });

        modelBuilder.Entity<TblHospitalRoom>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__tbl_hosp__19675A8A28E3EB53");

            entity.ToTable("tbl_hospital_room");

            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.FloorNumber).HasColumnName("floor_number");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.RoomNumber).HasColumnName("room_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Clinic).WithMany(p => p.TblHospitalRooms)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_room_tbl_hospital_clinic");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblHospitalRooms)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_room_tbl_doctor");

            entity.HasOne(d => d.Hospital).WithMany(p => p.TblHospitalRooms)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_hospital_room_tbl_hospital");
        });

        modelBuilder.Entity<TblIdentityNumber>(entity =>
        {
            entity.HasKey(e => e.IdentityNumberId);

            entity.ToTable("tbl_identity_numbers");

            entity.Property(e => e.IdentityNumberId).HasColumnName("identity_number_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IdentityNumber).HasColumnName("identity_number");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
        });

        modelBuilder.Entity<TblMailService>(entity =>
        {
            entity.HasKey(e => e.MailServicesId);

            entity.ToTable("tbl_mail_services");

            entity.Property(e => e.MailServicesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("mail_services_id");
            entity.Property(e => e.MailServicesName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail_services_name");
        });

        modelBuilder.Entity<TblMedication>(entity =>
        {
            entity.HasKey(e => e.MedicationId);

            entity.ToTable("tbl_medication");

            entity.Property(e => e.MedicationId).HasColumnName("medication_id");
            entity.Property(e => e.MedicationName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("medication_name");
            entity.Property(e => e.MedicationType)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("medication_type");
        });

        modelBuilder.Entity<TblPatient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__tbl_pati__4D5CE476CDF88822");

            entity.ToTable("tbl_patient");

            entity.HasIndex(e => e.EmailId, "UQ_Email")
                .IsUnique()
                .HasFilter("([is_deleted]=(0))");

            entity.HasIndex(e => e.IdentityNumberId, "UQ_IdentityNumber")
                .IsUnique()
                .HasFilter("([is_deleted]=(0))");

            entity.HasIndex(e => e.PhoneNumberId, "UQ_PhoneNumber")
                .IsUnique()
                .HasFilter("([is_deleted]=(0))");

            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.BloodGroupId).HasColumnName("blood_group_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.EmailId).HasColumnName("email_id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.IdentityNumberId).HasColumnName("identity_number_id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");

            entity.HasOne(d => d.BloodGroup).WithMany(p => p.TblPatients)
                .HasForeignKey(d => d.BloodGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_tbl_blood_group");

            entity.HasOne(d => d.Email).WithOne(p => p.TblPatient)
                .HasForeignKey<TblPatient>(d => d.EmailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_tbl_email_addresses");

            entity.HasOne(d => d.IdentityNumber).WithOne(p => p.TblPatient)
                .HasForeignKey<TblPatient>(d => d.IdentityNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_tbl_identity_numbers");

            entity.HasOne(d => d.PhoneNumber).WithOne(p => p.TblPatient)
                .HasForeignKey<TblPatient>(d => d.PhoneNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_tbl_phone_numbers");
        });

        modelBuilder.Entity<TblPatientAllergy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_pati__3213E83F38F012D1");

            entity.ToTable("tbl_patient_allergy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllergyId).HasColumnName("allergy_id");
            entity.Property(e => e.DiagnosisDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("diagnosis_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");

            entity.HasOne(d => d.Allergy).WithMany(p => p.TblPatientAllergies)
                .HasForeignKey(d => d.AllergyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_allergy_tbl_allergy");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblPatientAllergies)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_allergy_tbl_patient");
        });

        modelBuilder.Entity<TblPatientChronicDisease>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_pati__3213E83FB6004336");

            entity.ToTable("tbl_patient_chronic_disease");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChronicDiseaseId).HasColumnName("chronic_disease_id");
            entity.Property(e => e.DiagnosisDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("diagnosis_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");

            entity.HasOne(d => d.ChronicDisease).WithMany(p => p.TblPatientChronicDiseases)
                .HasForeignKey(d => d.ChronicDiseaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_chronic_disease_tbl_chronic_disease");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblPatientChronicDiseases)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_patient_chronic_disease_tbl_patient");
        });

        modelBuilder.Entity<TblPhoneNumber>(entity =>
        {
            entity.HasKey(e => e.PhoneNumberId).HasName("PK__tbl_phon__7DB84303B464EE3E");

            entity.ToTable("tbl_phone_numbers");

            entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
        });

        modelBuilder.Entity<TblPrescription>(entity =>
        {
            entity.ToTable("tbl_prescription");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.MedicationId).HasColumnName("medication_id");
            entity.Property(e => e.MedicationQuantity).HasColumnName("medication_quantity");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PrescriptionCreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("prescription_creation_date");

            entity.HasOne(d => d.Appointment).WithMany(p => p.TblPrescriptions)
                .HasForeignKey(d => d.AppointmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_prescription_tbl_appointment");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblPrescriptions)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_prescription_tbl_doctor");

            entity.HasOne(d => d.Medication).WithMany(p => p.TblPrescriptions)
                .HasForeignKey(d => d.MedicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_prescription_tbl_medication");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblPrescriptions)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_prescription_tbl_patient");
        });

        modelBuilder.Entity<TblProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId);

            entity.ToTable("tbl_province");

            entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            entity.Property(e => e.ProvinceAreaCode).HasColumnName("province_area_code");
            entity.Property(e => e.ProvinceHasBranch)
                .HasDefaultValue(true)
                .HasColumnName("province_has_branch");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("province_name");
        });

        modelBuilder.Entity<TblRequestType>(entity =>
        {
            entity.HasKey(e => e.RequestTypeId).HasName("PK__tbl_requ__C24DD950CA8145A3");

            entity.ToTable("tbl_request_types");

            entity.HasIndex(e => e.RequestTypeName, "UQ__tbl_requ__3F1813EFB510F409").IsUnique();

            entity.Property(e => e.RequestTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("request_type_id");
            entity.Property(e => e.RequestTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("request_type_name");
        });

        modelBuilder.Entity<TblSessionToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__tbl_sess__CB3C9E171EB053AC");

            entity.ToTable("tbl_session_token");

            entity.Property(e => e.TokenId).HasColumnName("token_id");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.TokenCreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("token_created_at");
            entity.Property(e => e.TokenExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("token_expires_at");
            entity.Property(e => e.TokenIsActive)
                .HasDefaultValue(true)
                .HasColumnName("token_is_active");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.TblSessionTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_session_token_tbl_user");
        });

        modelBuilder.Entity<TblSupportTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__tbl_supp__D596F96BFEEF0D0D");

            entity.ToTable("tbl_support_tickets");

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.AssignedTo).HasColumnName("assigned_to");
            entity.Property(e => e.IssueDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("issue_date");
            entity.Property(e => e.IssueDescription)
                .IsUnicode(false)
                .HasColumnName("issue_description");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("last_update");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("mac_address");
            entity.Property(e => e.RequestTypeId).HasColumnName("request_type_id");
            entity.Property(e => e.ResolvedDate)
                .HasColumnType("datetime")
                .HasColumnName("resolved_date");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("response");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasColumnName("status");
            entity.Property(e => e.UserIdentityNo).HasColumnName("user_identity_no");

            entity.HasOne(d => d.RequestType).WithMany(p => p.TblSupportTickets)
                .HasForeignKey(d => d.RequestTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_support_tickets_tbl_request_types");
        });

        modelBuilder.Entity<TblTempBannedMacAddress>(entity =>
        {
            entity.HasKey(e => e.TempBanId).HasName("PK__tbl_temp__CA318F1649887CBD");

            entity.ToTable("tbl_temp_banned_mac_address");

            entity.Property(e => e.TempBanId).HasColumnName("temp_ban_id");
            entity.Property(e => e.BanEndTime)
                .HasDefaultValueSql("(dateadd(minute,(5),getdate()))")
                .HasColumnType("datetime")
                .HasColumnName("ban_end_time");
            entity.Property(e => e.BanStartTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ban_start_time");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("mac_address");
        });

        modelBuilder.Entity<TblTest>(entity =>
        {
            entity.HasKey(e => e.TestId).HasName("PK__tbl_test__F3FF1C02FB7754B5");

            entity.ToTable("tbl_test");

            entity.Property(e => e.TestId).HasColumnName("test_id");
            entity.Property(e => e.MaxValueFemale).HasColumnName("max_value_female");
            entity.Property(e => e.MaxValueMale).HasColumnName("max_value_male");
            entity.Property(e => e.MinValueFemale).HasColumnName("min_value_female");
            entity.Property(e => e.MinValueMale).HasColumnName("min_value_male");
            entity.Property(e => e.TestName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("test_name");
        });

        modelBuilder.Entity<TblTestResult>(entity =>
        {
            entity.HasKey(e => e.ResultId);

            entity.ToTable("tbl_test_result");

            entity.Property(e => e.ResultId).HasColumnName("result_id");
            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.DoctorControl).HasColumnName("doctor_control");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ResultDate)
                .HasColumnType("datetime")
                .HasColumnName("result_date");
            entity.Property(e => e.TestId).HasColumnName("test_id");
            entity.Property(e => e.TestRequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("test_request_date");
            entity.Property(e => e.TestResult).HasColumnName("test_result");

            entity.HasOne(d => d.Appointment).WithMany(p => p.TblTestResults)
                .HasForeignKey(d => d.AppointmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_test_result_tbl_appointment");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblTestResults)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_test_result_tbl_doctor");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblTestResults)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_test_result_tbl_patient");

            entity.HasOne(d => d.Test).WithMany(p => p.TblTestResults)
                .HasForeignKey(d => d.TestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_test_result_tbl_test");
        });

        modelBuilder.Entity<TblTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("tbl_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("title_id");
            entity.Property(e => e.TitleDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title_description");
            entity.Property(e => e.TitleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("title_name");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tbl_user");

            entity.HasIndex(e => e.IdentityNumberId, "UQ_UserIdentityNumber")
                .IsUnique()
                .HasFilter("([is_deleted]=(0))");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IdentityNumberId).HasColumnName("identity_number_id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.TempIdentityNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("temp_identity_number");
            entity.Property(e => e.TempPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("temp_password");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.IdentityNumber).WithOne(p => p.TblUser)
                .HasForeignKey<TblUser>(d => d.IdentityNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_user_tbl_identity_numbers");

            entity.HasOne(d => d.Type).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_user_tbl_user_type");
        });

        modelBuilder.Entity<TblUserAccessHour>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK__tbl_user__9424CFA6B9807BEF");

            entity.ToTable("tbl_user_access_hours");

            entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
        });

        modelBuilder.Entity<TblUserSessionLog>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__tbl_user__482FBD636F61034A");

            entity.ToTable("tbl_user_session_log");

            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("ip_address");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("login_time");
            entity.Property(e => e.LogoutTime)
                .HasColumnType("datetime")
                .HasColumnName("logout_time");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("mac_address");
            entity.Property(e => e.SessionDuration).HasColumnName("session_duration");
            entity.Property(e => e.SessionToken).HasColumnName("session_token");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.TblUserSessionLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_user_activity_log_tbl_user");
        });

        modelBuilder.Entity<TblUserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK__tbl_user__9424CFA6310ADE40");

            entity.ToTable("tbl_user_type");

            entity.Property(e => e.UserTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("user_type_id");
            entity.Property(e => e.AllowedEndTime).HasColumnName("allowed_end_time");
            entity.Property(e => e.AllowedStartTime).HasColumnName("allowed_start_time");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_type_name");
        });

        modelBuilder.Entity<TblVisit>(entity =>
        {
            entity.HasKey(e => e.VisitId);

            entity.ToTable("tbl_visit");

            entity.Property(e => e.VisitId).HasColumnName("visit_id");
            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.Diagnosis)
                .IsUnicode(false)
                .HasColumnName("diagnosis");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Rates).HasColumnName("rates");
            entity.Property(e => e.VisitDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("visit_date");

            entity.HasOne(d => d.Appointment).WithMany(p => p.TblVisits)
                .HasForeignKey(d => d.AppointmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_visit_tbl_appointment");

            entity.HasOne(d => d.Clinic).WithMany(p => p.TblVisits)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_visit_tbl_hospital_clinic");

            entity.HasOne(d => d.Doctor).WithMany(p => p.TblVisits)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_visit_tbl_doctor");

            entity.HasOne(d => d.Hospital).WithMany(p => p.TblVisits)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_visit_tbl_hospital");

            entity.HasOne(d => d.Patient).WithMany(p => p.TblVisits)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_visit_tbl_patient");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
