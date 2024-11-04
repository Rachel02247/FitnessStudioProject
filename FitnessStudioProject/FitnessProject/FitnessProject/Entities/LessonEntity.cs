namespace FitnessProject.Entities
{
    public class LessonEntity
    {
        public int Id { get; set; }
        public CourseEntity Course { get; set; }
        public RoomEntity Room { get; set; }
        public DateOnly Date { get; set; }
        public string Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int ParticipantsAmount { get; set; }

        public LessonEntity()
        {

        }
        public LessonEntity(int id,CourseEntity course, RoomEntity room, DateOnly date, string day,
            TimeOnly startTime, TimeOnly endTime, int participantsAmount)
        {
            Id = id;
            Course = course;
            Room = room;
            Date = date;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
            ParticipantsAmount = participantsAmount;
        }
    }
}
