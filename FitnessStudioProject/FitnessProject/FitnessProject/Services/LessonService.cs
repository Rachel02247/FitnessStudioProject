using FitnessProject.Entities;

namespace FitnessProject.Services
{
    public class LessonService
    {
        public List<LessonEntity> LessonList { get; set; }
        public LessonService()
        {
            LessonList = new List<LessonEntity>();
        }
        public bool AddLesson(LessonEntity lessondb)
        {
            if (LessonList == null)
                return false;
            LessonList.Add(lessondb);
            return true;
        }
        public LessonEntity getID(int id)
        {
            if (LessonList == null)
            { return null; }
            return LessonList.Where(c => c.Id == id).FirstOrDefault<LessonEntity>();
        }
     
        public void UpdateLesson(int id, LessonEntity value)
        {
            LessonList.Insert(id, value);
        }
    }
}
