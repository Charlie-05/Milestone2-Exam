using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BikeRentalManagementSystem
{

    internal class BikeRepository
    {
        static string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=BikeRentalManagement;";

        public void AddBike(Bike bike)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Bikes (Brand,Model,RentalPrice) VALUES (@Brand , @Model , @RentalPrice)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Brand", bike.Brand);
                    cmd.Parameters.AddWithValue("@Model", bike.Model);
                    cmd.Parameters.AddWithValue("@RentalPrice", bike.RentalPrice);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Bike Added Successfully");
                }
            }
        }

        public string GetBikeByID(int bikeId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "select * from Bikes Where BikeId = @BikeId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BikeId", bikeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return ($"Bike ID :{reader["BikeId"]} , Brand : {reader["Brand"]}, Model : {reader["Model"]}, Rental Price : {reader["rentalPrice"]}");
                    }
                    return null;
                }
            }
        }

        public string GetAllBikes()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Bikes";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    string returnStr = "";
                    while (reader.Read())
                    {
                        returnStr += ($"Bike ID :{reader["BikeId"]} , Brand : {reader["Brand"]}, Model : {reader["Model"]}, Rental Price : {reader["rentalPrice"]}\n");
                    }
                    return returnStr;
                }
            }
        }

        public void UpdateBike(Bike bike)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Bikes set Brand = @Brand , Model = @Model , RentalPrice = @RentalPrice where BikeId = @BikeId;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BikeId", bike.BikeId);
                    cmd.Parameters.AddWithValue("@Brand", bike.Brand);
                    cmd.Parameters.AddWithValue("@Model", bike.Model);
                    cmd.Parameters.AddWithValue("@RentalPrice", bike.RentalPrice);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine(" Updated Succesfully...");
                    }
                    else
                    {
                        Console.WriteLine("Course not Found...");
                    }
                }
            }
        }

        public void DeleteBike(int bikeId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "delete from bikes where BikeId = @BikeId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BikeId" , bikeId);
                    int rowsAffected = cmd.ExecuteNonQuery();   
                    if(rowsAffected > 0)
                    {
                        Console.WriteLine("Bike deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Error deleting Bike");
                    }
                }
            }
        }
    }
}
