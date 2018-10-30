using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CourierPro
{
    public class Data
    {
        // public string name {get; set;}
        // public string address {get; set;}
        // public string accountID {get; set; }
        // public string driverID {get; set;}
        // public string packageID {get; set; }
        // public string packageCagtegory {get; set;}
        // public string price {get; set;}
        // public string delevirylocation {get; set;}
        // public string pickupdestination {get; set;}
        // public string packageStatus {get; set;}



        public int Weight { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public override string ToString()
        {
            return string.Format("Weight: {0}, Name: {1}, Breed: {2}",
                Weight, Name, Breed);
        }
    }

    public static void Main()
    {
        TryCreateTable();
        while (true)
        {
            Console.WriteLine("INPUT TYPE:\tWeight,Name,Breed\tor\tSELECT:");
            string[] input = Console.ReadLine().Split(',');
            try
            {
                char c = char.ToLower(input[0][0]);
                if (c == 's')
                {
                    DisplayDogs();
                    continue;
                }
                int weight = int.Parse(input[0]); // The dog weight.
                string name = input[1];           // The name string.
                string breed = input[2];          // The breed string.
                AddDog(weight, name, breed);      // Add the data to the SQL database.
            }
            catch
            {
                Console.WriteLine("Input error");
            }
        }
    }

    /// <summary>
    /// This method attempts to create the Dogs1 SQL table.
    /// If will do nothing but print an error if the table already exists.
    /// </summary>
    public static void TryCreateTable()
    {
        using (SqlConnection con = new SqlConnection(
            ConsoleApplication1.Properties.Settings.Default.masterConnectionString))
        {
            con.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "CREATE TABLE Dogs1 (Weight INT, Name TEXT, Breed TEXT)", con))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                Console.WriteLine("Table not created.");
            }
        }
    }

    /// <summary>
    /// Insert dog data into the SQL database table.
    /// </summary>
    /// <param name="weight">The weight of the dog.</param>
    /// <param name="name">The name of the dog.</param>
    /// <param name="breed">The breed of the dog.</param>
    public static void AddDog(int weight, string name, string breed)
    {
        using (SqlConnection con = new SqlConnection(
            ConsoleApplication1.Properties.Settings.Default.masterConnectionString))
        {
            con.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Dogs1 VALUES(@Weight, @Name, @Breed)", con))
                {
                    command.Parameters.Add(new SqlParameter("Weight", weight));
                    command.Parameters.Add(new SqlParameter("Name", name));
                    command.Parameters.Add(new SqlParameter("Breed", breed));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                Console.WriteLine("Count not insert.");
            }
        }
    }

    /// <summary>
    /// Read in all rows from the Dogs1 table and store them in a List.
    /// </summary>
    public static void DisplayDogs()
    {
        List<Dog> dogs = new List<Dog>();
        using (SqlConnection con = new SqlConnection(
            ConsoleApplication1.Properties.Settings.Default.masterConnectionString))
        {
            con.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Dogs1", con))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int weight = reader.GetInt32(0);    // Weight int
                    string name = reader.GetString(1);  // Name string
                    string breed = reader.GetString(2); // Breed string
                    dogs.Add(new Dog() { Weight = weight, Name = name, Breed = breed });
                }
            }
        }
        foreach (Dog dog in dogs)
        {
            Console.WriteLine(dog);
        }
    }

}
