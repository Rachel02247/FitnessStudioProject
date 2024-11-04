﻿namespace FitnessProject.Entities
{
    [Flags]
    public enum CourseType { BALLET = 0, FLOOR = 1, AEROBICS = 2, BAYLLA = 4, ZOMBA = 8, HIPHOP = 16, DANCE = 32 }

    public class CourseEntity
    {
        public int Id {  get; set; }
        public CourseType Name { get; set; }
        public int MeetingNumbers { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public TrainerEntity Trainer { get; set; }
        public Rooms PreferredRoom { get; set; }
        public string Equipment { get; set; }
        public CourseEntity() { }

        public CourseEntity(CourseType name, int meetingNumbers, DateOnly startDate,
            DateOnly endDate, TrainerEntity trainer, Rooms preferredRoom, string equipment)
        {
            
            Name = name;
            MeetingNumbers = meetingNumbers;
            StartDate = startDate;
            EndDate = endDate;
            Trainer = trainer;
            PreferredRoom = preferredRoom;
            Equipment = equipment;
        }

    }
}
