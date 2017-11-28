using Pzpn.Team.Domain.Mappers;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Pzpn.Team.Domain.Sql
{
    public class TableRepository<TEntity>
    {
        private SqlDatabaseClient _sqlDatabaseClient;
        private readonly ITableMap<TEntity> _tableMap;

        private string SelectAllQuery => $"SELECT {string.Join(", ", _tableMap.Columns)} FROM {_tableMap.TableName}";
        private string SelectCount => $"SELECT COUNT(*) FROM {_tableMap.TableName}";

        public TableRepository(ITableMap<TEntity> tableMap)
        {
            _sqlDatabaseClient = new SqlDatabaseClient();
            _tableMap = tableMap;
        }

        protected IEnumerable<TEntity> GetAllEntities()
        {
            return _sqlDatabaseClient.ExecuteQuery(SelectAllQuery, _tableMap.ToEntity);
        }

        protected IEnumerable<TEntity> GetFilteredEntities(string whereSentence, SqlParameter[] parameters)
        {
            var query = $"{SelectAllQuery} WHERE {whereSentence}";
            return _sqlDatabaseClient.ExecuteQuery(query, _tableMap.ToEntity, parameters);
        }

        protected int GetCount()
        {
            return _sqlDatabaseClient.ExecuteScalar<int>(SelectCount);
        }
    }
}
