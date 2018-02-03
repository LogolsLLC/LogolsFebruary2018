using Assessment.Entities;
using System.Collections.Generic;

namespace Assessment.Entities.DataInterface
{
    public interface ILevelRepository
    {
        void Insert(Level level);

        void Delete(int levelID);

        void Update(Level level);

        Level Get(int levelID);

        IEnumerable<Level> GetAll();
    }
}