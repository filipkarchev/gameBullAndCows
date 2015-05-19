using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bullsAndCows
{
    class UserData
    {

        public static bool InsertUser(User u)
        {
           
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.AddNewUser(u.UserName,u.Number );
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        public static User GetUserById(int id)
        {
            return UserData._GetUserById(id);
        }
        private static User _GetUserById(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Id == id) 
                               select users).ToArray<User>();
            User user = queryResult.ElementAt<User>(0);
            
            return user;
        }
    }
}
