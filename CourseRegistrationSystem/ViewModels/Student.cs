﻿using CourseRegistrationSystem.Helpers;
using CourseRegistrationSystem.Infrastructure;
using CourseRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CourseRegistrationSystem.ViewModels
{
    // A ViewModel is a representation of the model used to present information to the View
    // Below I have five ViewModels, they are named using the Controller and then the Action name i.e.
    // WelcomeIndex => ControllerName = Welcome Action/Method name = Index except for the last VM
    // A model/ViewModel is represented by a class with Properties like below
    // presents the students firstname and photo in the profile, and the Profile pix for uploading
    public class WelcomeIndex
    {
        public string FirstName { get; set; }
        public byte[] Photo { get; set; }

        [Required]
        [FileSize(150000)]
        [FileTypes("jpg,jpeg")]
        public HttpPostedFileBase ProfilePic { get; set; }
    }

    // presents the View when the user clicks Student Profile Details
    public class WelcomeBiodata
    {
        [Required, DisplayName("Firstname"), MaxLength(50)]
        public string FirstName { get; set; }

        [Required, DisplayName("Lastname"), MaxLength(50)]
        public string LastName { get; set; }

        [DisplayName("Middlename"), MaxLength(50)]
        public string MiddleName { get; set; }

        [Required, DisplayName("Matric Number"), MaxLength(11)]
        public string RegistrationNumber { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(128)]
        public string Email { get; set; }

        [Required, DataType(DataType.MultilineText), MaxLength(256)]
        public string Address { get; set; }

        [Required, DisplayName("Phone"), DataType(DataType.PhoneNumber), MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required, DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }

        [Required, EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        public States State { get; set; }

        [Required, MaxLength(50), Display(Name = "L. G. A.")]
        public string LGA { get; set; }

        [Required, MaxLength(128)]
        public string Hometown { get; set; }

        [Required, EnumDataType(typeof(Country))]
        public Country Country { get; set; }

        [Required, DisplayName("Course"), MaxLength(128)]
        public string CourseOfStudy { get; set; }

        [Required, MaxLength(50)]
        public string Department { get; set; }

        [Required, EnumDataType(typeof(Level))]
        public Level Level { get; set; }

        [DisplayName("Blood Group"), EnumDataType(typeof(BloodGroup))]
        public BloodGroup BloodGroup { get; set; }

        [Required, EnumDataType(typeof(Genotype))]
        public Genotype Genotype { get; set; }

        [EnumDataType(typeof(Disability))]
        public Disability Disability { get; set; }

        [Required, Display(Name = "Sponsor's Name")]
        public string SponsorName { get; set; }

        [Required, Display(Name = "Sponsor's Phone")]
        public string SponsorPhone { get; set; }
    }

    // presents the View when the user clicks Change Password
    public class WelcomeChangePassword
    {
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DisplayName("Confirm Password")]
        [DataType(DataType.Password), System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and Confirm Password Must Match")]
        public string ConfirmPassword { get; set; }
    }

    // presents the View for View Registration
    public class WelcomeViewRegistration
    {
        [Required, DisplayName("Firstname"), MaxLength(50)]
        public string FirstName { get; set; }

        [Required, DisplayName("Lastname"), MaxLength(50)]
        public string LastName { get; set; }

        [DisplayName("Middlename"), MaxLength(50)]
        public string MiddleName { get; set; }

        [Required, DisplayName("Matric No"), MaxLength(11)]
        public string RegistrationNumber { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(128)]
        public string Email { get; set; }

        [Required, DataType(DataType.MultilineText), MaxLength(256)]
        public string Address { get; set; }

        [Required, DisplayName("Phone"), DataType(DataType.PhoneNumber), MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required, DisplayName("Date of Birth"), DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [Required, EnumDataType(typeof(Gender))]
        public string Gender { get; set; }

        [Required, Display(Name = "Sponsor")]
        public string SponsorName { get; set; }

        [Required, Display(Name = "Sponsor Phone")]
        public string SponsorPhone { get; set; }

        [Required]
        public string State { get; set; }

        [Required, MaxLength(50), Display(Name = "L. G. A.")]
        public string LGA { get; set; }

        [Required, MaxLength(128)]
        public string Hometown { get; set; }

        [Required, DisplayName("Course"), MaxLength(128)]
        public string CourseOfStudy { get; set; }

        [Required, MaxLength(50)]
        public string Department { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        [FileSize(150000)]
        [FileTypes("jpg,jpeg")]
        public byte[] Photo { get; set; }

        public string StudentType { get; set; }

        // passes the list of enroled courses to View Registration
        public List<EnrolledCourses> Enroll { get; set; }
    }

    // presents Enroled courses view
    public class EnrolledCourses
    {
        public Course Courses { get; set; }
        public Enrollment Enrolled { get; set; }
        public string Session
        {
            get
            {
                if (DateTime.Now.Month >= 10)
                {
                    return DateTime.Now.Year + "/" + DateTime.Now.Year + 1;
                }
                else
                {
                    return DateTime.Now.Year - 1 + "/" + DateTime.Now.Year;
                }
            }
        }
        public string Submitted { get; set; }
        public string Approved { get; set; }
    }
}
