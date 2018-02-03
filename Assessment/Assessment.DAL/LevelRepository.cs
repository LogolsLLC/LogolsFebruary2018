using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Assessment.Entities.DataInterface;
using Dapper;

namespace Assessment.DAL
{
    public class LevelRepository : Repository, ILevelRepository
    {
        public void Insert(Level level)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Insert into Level (LevelNumber, Name) values (@LevelNumber, @Name)"
                    , new { LevelNumber = level.LevelNumber, Name = level.Name }
                    , commandType: CommandType.Text);
            }
        }

        public void Delete(int levelNumber)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Delete From Level Where LevelNumber = @LevelNumber"
                    , new { LevelNumber = levelNumber }
                    , commandType: CommandType.Text);
            }
        }

        public void Update(Level level)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "Update Level Set LevelNumber = @LevelNumber, Name = @Name"
                    , level
                    , commandType: CommandType.Text);
            }
        }

        public Level Get(int levelNumber)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Level>(
                    "Select LevelNumber, Name From Level Where LevelNumber = @LevelNumber"
                    , new { LevelNumber = levelNumber }
                    , commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public IEnumerable<Level> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Level>(
                    "Select LevelNumber, Name From Level"
                    , commandType: CommandType.Text);
            }
        }
    }
}