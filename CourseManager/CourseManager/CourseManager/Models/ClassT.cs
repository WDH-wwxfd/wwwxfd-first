using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManage.Models
{
    public partial class Classes
    {
        public string TeacherName
        { 
        get{
            if (!TeacherId.HasValue) 
            {
                return "";

            }
            CourseManageEntities db = new CourseManageEntities();
            var teachers = db.Teachers.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
            if (teachers == null) {
                return "";
            }
            return teachers.Name;
        }
        }
    }
}