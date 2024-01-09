using Microsoft.Data.SqlClient;

namespace Casino;

public class ExceptionEntity
{
    public int Id { get; set; }
    public string ExceptionType { get; set; }
    public string ExceptionMessage { get; set; }
    public DateTime TimeStamp { get; set; }

    public static List<ExceptionEntity> ReadExceptions()
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=blackjack;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string queryString = "SELECT * FROM Exceptions";
        List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                ExceptionEntity exception = new ExceptionEntity();
                exception.Id = Convert.ToInt32(reader["Id"]);
                exception.ExceptionType = reader["ExceptionType"].ToString();
                exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                
                Exceptions.Add(exception);
            }
            
            connection.Close();
        }

        return Exceptions;
    }
}

