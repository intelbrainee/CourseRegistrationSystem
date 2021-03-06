﻿using FluentMigrator;

namespace CourseRegistrationSystem.Migrations
{
    [Migration(2, "Courses Table")] // same as described in UsersAndRoles, but with a description
    public class _002_Courses : Migration
    {
        public override void Down()
        {
            Delete.Table("courses");
        }

        public override void Up()
        {
            Create.Table("courses")
                .WithColumn("course_id").AsInt32().PrimaryKey().Identity() // PK auto-increment
                .WithColumn("course_code").AsString(7).NotNullable()
                .WithColumn("course_title").AsString(50).NotNullable()
                .WithColumn("course_info").AsCustom("VARCHAR(256)").Nullable()
                .WithColumn("department").AsString(50).NotNullable()
                .WithColumn("lecturer_name").AsString(50).Nullable().WithDefaultValue("Not Available")
                .WithColumn("level").AsInt32().NotNullable()
                .WithColumn("semester").AsString(7).NotNullable()
                .WithColumn("credit").AsString(7).NotNullable()
                .WithColumn("type").AsString(10).NotNullable();

            // after creating the table "courses", it inserts the following in the created table
            Insert.IntoTable("courses").Row(new { course_code = "CS 101", course_title = "Introduction to Computer Science", department = "Computer Science", lecturer_name = "C. I. Nwoye", level = 100, semester = "First", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 102", course_title = "Introduction to Computer Systems", department = "Computer Science", lecturer_name = "Mrs Uguwishiwu", level = 100, semester = "Second", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 104", course_title = "Computing Practice", department = "Computer Science", lecturer_name = "Mrs Ezugwu Obianuju", level = 100, semester = "Second", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 201", course_title = "Computer Programming I", department = "Computer Science", lecturer_name = "Mr Oguike", level = 200, semester = "First", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 251", course_title = "Assembly Language Programming", department = "Computer Science", lecturer_name = "Engr. Udanor Collins N.", level = 200, semester = "First", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 202", course_title = "Computer Programming II", department = "Computer Science", lecturer_name = "Dr M. C. Okoronkwo", level = 200, semester = "Second", credit = "2", type = "Major" });

            Insert.IntoTable("courses").Row(new { course_code = "CS 222", course_title = "Introduction to File Processing", department = "Computer Science", lecturer_name = "Dr (Mrs) Ezema", level = 200, semester = "Second", credit = "2", type = "Major" });
        }
    }
}
