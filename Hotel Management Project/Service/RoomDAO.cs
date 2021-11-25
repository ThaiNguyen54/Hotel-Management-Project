﻿using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management_Project.Service
{
    public class RoomDAO : IRoomDataService
    {
        string ConnectionString = @"Data Source=THAI;Initial Catalog=Hotel_Managment;Integrated Security=True";
        public int DeleteRoom(RoomModel room)
        {
            throw new NotImplementedException();
        }

        public List<RoomModel> GetAllRoom()
        {
            List<RoomModel> FoundRoom = new List<RoomModel>();
            string sqlStatement = "SELECT * FROM ROOM";
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        FoundRoom.Add(new RoomModel { RoomID = (int)reader[0], RoomTypeID = (int)reader[1], 
                            RoomName = (string)reader[2], RoomDescription = (string)reader[3], RoomPrice = (int)reader[4] });
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return FoundRoom;
        }

        public RoomModel GetRoomByID(int RoomID)
        {
            RoomModel FoundRoom = null;
            string sqlStatement = "SELECT * FROM ROOM WHERE room_id = @ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@ID", RoomID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FoundRoom = new RoomModel
                        {
                            RoomID = (int)reader[0],
                            RoomTypeID = (int)reader[1],
                            RoomName = (string)reader[2],
                            RoomDescription = (string)reader[3],
                            RoomPrice = (int)reader[4]
                        };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return FoundRoom;
        }

        public int InsertRoom(RoomModel room)
        {
            throw new NotImplementedException();
        }

        public List<RoomModel> SearchRoom(string SearchTerms)
        {
            throw new NotImplementedException();
        }

        public int UpdateRoom(RoomModel room)
        {
            throw new NotImplementedException();
        }
    }
}
