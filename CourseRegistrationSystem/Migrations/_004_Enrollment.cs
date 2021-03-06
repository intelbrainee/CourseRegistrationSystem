﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseRegistrationSystem.Migrations
{
    [Migration(4, "Enrollment table")]
    public class _004_Enrollment : Migration
    {
        public override void Down()
        {
            Delete.Table("enrollment");
        }

        public override void Up()
        {
            Create.Table("enrollment")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("course_id").AsInt32().ForeignKey("courses", "course_id").OnDeleteOrUpdate(System.Data.Rule.None)
                .WithColumn("student_id").AsInt32().ForeignKey("students", "id").OnDeleteOrUpdate(System.Data.Rule.None)
                .WithColumn("level").AsInt32().NotNullable()
                .WithColumn("semester").AsString(10).NotNullable()
                .WithColumn("status").AsString(8).NotNullable();
        }
    }
}