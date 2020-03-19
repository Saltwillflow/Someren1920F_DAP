using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Room_Service
    {
        Room_DAO room_db = new Room_DAO();

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> room = room_db.Db_Get_All_Rooms();
                return room;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Room> room = new List<Room>();
                Room a = new Room();
                a.Number = 111;
                a.Type = false;
                a.Capacity = 6;
                room.Add(a);
                Room b = new Room();
                b.Number = 222;
                b.Type = true;
                b.Capacity = 4;
                room.Add(b);
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                return room;
            }

        }
    }
}
