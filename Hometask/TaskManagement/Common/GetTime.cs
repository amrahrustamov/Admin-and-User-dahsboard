using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;

namespace TaskManagement.Common
{
    public static class GetTime
    {
        public static void GetTimes()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int userId = User.IdCounter;
            string userEmail = User.Email!;

            HistoryOfRegistration historyOfRegistration = new HistoryOfRegistration(year, month, day, hour, minute, userId, userEmail!);
            DataContext.DatesOfRegister.Add(historyOfRegistration);
        }
    }
}
