using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly IConfiguration _config;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkRepository(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public List<Walk> GetAllWalks()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT w.Id AS WalkId, Date, Duration, WalkerId, DogId, 
                               d.Name AS DogName, d.OwnerId AS OwnerId, d.Breed AS Breed,
                               o.Name AS OwnerName
                        FROM Walks w LEFT JOIN Dog d ON d.Id = W.DogId LEFT JOIN Owner o ON o.id = d.OwnerId
                    ";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Walk> walks = new List<Walk>();
                        while (reader.Read())
                        {
                            Walk walk = new Walk
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("WalkId")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                DogId = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Dog = new Dog
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                    Name = reader.GetString(reader.GetOrdinal("DogName")),
                                    OwnerId = reader.GetInt32(reader.GetOrdinal("OwnerId")),
                                    Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                    Owner = new Owner
                                    {
                                        Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                    }
                                }
                            };

                            walks.Add(walk);
                        }

                        return walks;
                    }
                }
            }
        }

        public Walk GetWalkById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT w.Id AS WalkId, Date, Duration, WalkerId, DogId, 
                               d.Name AS DogName, d.OwnerId AS OwnerId, d.Breed AS Breed,
                               o.Name AS OwnerName
                        FROM Walks w LEFT JOIN Dog d ON d.Id = W.DogId LEFT JOIN Owner o ON o.id = d.OwnerId
                        Where w.Id = @id
                    ";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Walk walk = new Walk
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("WalkId")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                DogId = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Dog = new Dog
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                    Name = reader.GetString(reader.GetOrdinal("DogName")),
                                    OwnerId = reader.GetInt32(reader.GetOrdinal("OwnerId")),
                                    Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                    Owner = new Owner
                                    {
                                        Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                    }
                                }
                            };

                            return walk;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public List<Walk> GetWalksByWalker(int walkerId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT w.Id AS WalkId, Date, Duration, WalkerId, DogId, 
                               d.Name AS DogName, d.OwnerId AS OwnerId, d.Breed AS Breed,
                               o.Name AS OwnerName
                        FROM Walks w LEFT JOIN Dog d ON d.Id = W.DogId LEFT JOIN Owner o ON o.id = d.OwnerId
                        WHERE WalkerId = @walkerId
                        ";

                    cmd.Parameters.AddWithValue("@walkerId", walkerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        List<Walk> walks = new List<Walk>();
                        while (reader.Read())
                        {
                            Walk walk = new Walk
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("WalkId")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                DogId = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Dog = new Dog
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                    Name = reader.GetString(reader.GetOrdinal("DogName")),
                                    OwnerId = reader.GetInt32(reader.GetOrdinal("OwnerId")),
                                    Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                    Owner = new Owner
                                    {
                                        Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                    }
                                }
                            };

                            walks.Add(walk);
                        }

                        return walks;
                    }
                }
            }
        }
    }
}