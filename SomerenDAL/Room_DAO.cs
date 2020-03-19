using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Room_DAO : Base
    {
        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT room_number, room_type, room_size FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();


            foreach (DataRow dr in dataTable.Rows)
            {
                
                Room room = new Room()
                {
                    Number = (int)dr["room_number"],
                    Type = (bool)dr["room_type"],
                    Capacity = (int)(dr["room_size"])
                };
                rooms.Add(room);
            }
            return rooms;

        }
    }
}
