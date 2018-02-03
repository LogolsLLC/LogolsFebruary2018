using System;
using System.Collections.Generic;
using Assessment.Entities.DataInterface;

namespace Assessment.Entities
{
    public class LevelService
    {
        private ILevelRepository _repository;

        public LevelService(ILevelRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Level level)
        {
            _repository.Insert(level);
        }

        public void Delete(int levelID)
        {
            _repository.Delete(levelID);
        }

        public void Update(Level level)
        {
            _repository.Update(level);
        }

        public Level Get(int levelID)
        {
            return _repository.Get(levelID);
        }

        public IEnumerable<Level> GetAll()
        {
            return _repository.GetAll();
        }
    }
}