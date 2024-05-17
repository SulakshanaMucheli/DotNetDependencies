using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using DotNetDependencies.Models;
using System.Reflection;
using DotNetDependencies.data;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace DotNetDependencies
{
    public class Program
    {
        public static void Main(string[] args)
        {   IConfiguration config =new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();
            dataDapper dapper = new dataDapper(config);
            // dataEntityF EntityFramework = new dataEntityF(config);
        //    string connectionstring = @"server=localhost\sqlexpress;database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
           //dapper is used 
        //    IDbConnection dbConnection = new SqlConnection(connectionstring);
         //string sqlcommand = "SELECT GETDATE()";
        //DateTime rightnow= dapper.Loadingdata<DateTime>(sqlcommand);
        //    Console.WriteLine(rightnow);

        //inserting the data into database
            // Users user1 = new Users()
            // {
            //  userId=107,
            //  Firstname="maheswari",
            //  Lastname="THokala",
            //  PASSWORD="abc@1234"
            //  };

            //EntityFramework.Add(user1);
            //EntityFramework.SaveChanges();
             // Retrieve the entity you want to delete by its primary key
           
            // EntityFramework.Remove(user1); // Mark the entity for deletion
            // EntityFramework.SaveChanges(); // Commit the deletion to the database
            
            // creating the file with the text.
            // String sql ="My name is sulakshana";
            // File.WriteAllText("log.txt",sql);
            // using StreamWriter openFile = new("log.txt",append:true);
            // openFile.WriteLine(sql);
            // openFile.Close();
            string UsersJson = File.ReadAllText("users.json");
            // Console.WriteLine(File.ReadAllText("log.txt"));
            // IEnumerable<User>?Users = JsonSerializer.Deserialize<IEnumerable<User>>(UsersJson); 
             IEnumerable<Users>?users = JsonSerializer.Deserialize<IEnumerable<Users>>(UsersJson);
             if(users!=null)
             {
                foreach(Users user in users)
                {
                    // Console.WriteLine(user.userId);
                    string sql=@"INSERT INTO Company.users(userId,Firstname,Lastname,PASSWORD)VALUES('"+user.userId+"','"+user.Firstname+"','"+user.Lastname+"','"+user.PASSWORD+"')";
                     dapper.Executesql(sql);
                }
             }
            //string sql=@"INSERT INTO Company.users(userId,Firstname,Lastname,PASSWORD)VALUES('"+user1.userId+"','"+user1.Firstname+"','"+user1.Lastname+"','"+user1.PASSWORD+"')";
            //int result =dapper.Executesql(sql);
            //Console.WriteLine(result);
            //select the array of my computer using dapper
            //string sqlselect =@"SELECT * FROM Company.Users";
            //if you have one table were you can use *
            //if you have multiple tables in schema have to use schema.tablename
            //IEnumerable<Users>user=dapper.Loadingdata<Users>(sqlselect);
        }    
    }
}
