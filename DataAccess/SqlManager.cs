using Dapper;
using StudentsLogInForm.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class SqlManager
    {
        private static string GetConnectionString() => ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

        public static bool SaveStudentToDatabase(Student student)
        {
            using (var connection = new SqlConnection(GetConnectionString()))
            {
                connection.Execute("student_InsertStudent", student, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
    }

}
