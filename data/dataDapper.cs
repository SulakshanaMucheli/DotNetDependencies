

using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DotNetDependencies.data
{
    public class dataDapper
    {
        private IConfiguration _config;
        public dataDapper(IConfiguration config)
        {
            _config=config;
        }
        //database connection 
     //string _connectionstring = @"server=localhost\sqlexpress;database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
        //inserting the data in the database
        public IEnumerable<S> Loadingdata<S>(String sql)
        {
           IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("connection"));
           return dbConnection.Query<S>(sql);
        } 
        public int Executesql(String sql)
        {
            IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("connection"));
           return dbConnection.Execute(sql);
        } 
    }
}