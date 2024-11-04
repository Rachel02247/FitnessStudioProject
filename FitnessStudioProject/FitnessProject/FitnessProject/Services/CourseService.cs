using FitnessProject.Entities;
using Microsoft.Extensions.Logging;

namespace FitnessProject.Services
{
    public class CourseService
    {
        public List<CourseEntity> CourseList { get; set; }
        public CourseService()
        {
            CourseList = new List<CourseEntity>();
        }
        public bool AddCourse(CourseEntity coursedb)
        {
            if (CourseList == null)
                return false;
            CourseList.Add(coursedb);
            return true;
        }
        public CourseEntity getID(int id)
        {
            if (CourseList == null)
            { return null; }
            return CourseList.Where(c => c.Id == id).FirstOrDefault<CourseEntity>();
        }
        //public int IdForName(CourseType name)
        //{
        //    if (CourseList == null)
        //        return 0;
        //    return CourseList.Where(c => c.Name == name).FirstOrDefault<CourseEntity>().Id;
        //}
        
        public void UpdateCourse(int id, CourseEntity value)
        {
            CourseList.Insert(id, value);
        }

    }
}
