using FitnessProject.Entities;

namespace FitnessProject.Services
{
    public class GymnastService
    {
        public List<GymnastEntity> GymnastList { get; set; }
        public GymnastService()
        {
            GymnastList = new List<GymnastEntity>();
        }
        public bool AddGymnast(GymnastEntity gymnastdb)
        {
            if (GymnastList == null)
                return false;
            GymnastList.Add(gymnastdb);
            return true;
        }
        public GymnastEntity getID(int id)
        {
            if (GymnastList == null)
            { return null; }
            return GymnastList.Where(c => c.Id == id).FirstOrDefault<GymnastEntity>();
        }
        //public int IDForId(string id)
        //{
        //    if (GymnastList == null)
        //        return 0;
        //    return GymnastList.Where(c => c.Id == id).
        //}

        public void UpdateGymnast(int id, GymnastEntity value)
        {
            GymnastList.Insert(id, value);
        }

    }
}

