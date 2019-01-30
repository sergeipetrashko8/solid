using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class Service : IDataService<IEntity>
    {
        //private const string _connectionString = "[connectionString]";
        private readonly IDbConnection _dbConnection;

        public Service(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public void Save(IEntity entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();
        }

        public IEnumerable<IEntity> ReadAll()
        {
            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();
            return new List<IEntity>();
        }

    }
}
