using System.Data;
using CardGame;
using Microsoft.Data.SqlClient;

namespace Casino;

public abstract class Game
{
    private List<Player> _players = new List<Player>();
    // Set properties for base game
    public List<Player> Players { get => _players; set => _players = value; }
    private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
    
    public string Name { get; set; }
    public string Dealer { get; set; }
    public Dictionary<Player, int> Bets { get => _bets; set => _bets = value; }

    // Set base method for play to be overridden by each game type
    public abstract void Play();
    
    public virtual void ListPlayers()
    {
        foreach (var player in Players)
        {
            Console.WriteLine(player.Name);
        }
    }
    
    public static void UpdateDbWithException(Exception ex)
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=blackjack;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";
        
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            
            command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
            command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
            command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

            command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
            command.Parameters["@ExceptionMessage"].Value = ex.Message;
            command.Parameters["@TimeStamp"].Value = DateTime.Now;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}