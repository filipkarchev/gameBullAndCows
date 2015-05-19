using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bullsAndCows
{
    class AtemptData
    {
        public static bool InsertAtempt(Atempt a)
        {

            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.AddNewAttempt(a.id_user,a.number,a.bulls,a.cows);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool DeleteData()
        {

            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.TruncateAttempts();
                dc.TruncateUsers();
               
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static string GetAtemptByUserId(int user_id)
        {
            return AtemptData._GetAtemptByUserId(user_id);
        }
        private static string _GetAtemptByUserId(int id)
        {
            string history=null;
            Atempt at;
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from atempts in dc.GetTable<Atempt>()
                               where (atempts.id_user==id)
                               select atempts).ToArray<Atempt>();
            for (int i = 0; i < queryResult.Count<Atempt>(); i++)
            {
                at = queryResult.ElementAt<Atempt>(i);
                history += "Числото " + at.number.ToString() + "има " + at.bulls + "бика, и " + at.cows + "крави"+"\r\n";
            }
           

            return history;
        }
    }
}
