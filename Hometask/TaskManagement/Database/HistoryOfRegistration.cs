using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Common;

namespace TaskManagement.Database
{
    public class HistoryOfRegistration
    {
        public HistoryOfRegistration(int year, int month, int day, int hour, int minute, int userId, string userEmail)
        {
            _Year = year;
            _Month = month;
            _Day = day;
            _Hour = hour;
            _Minute = minute;
            _UserId = userId;
            _UserEmail = userEmail;
        }
        public int _Year { get; set; }
        public int _Month { get; set; }
        public int _Day { get; set; }
        public int _Hour{ get; set; }
        public int _Minute { get; set; }
        public int _UserId { get; set; }
        public string _UserEmail { get; set; }
    }       
}
