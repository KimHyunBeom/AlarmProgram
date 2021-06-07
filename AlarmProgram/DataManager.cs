using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProgram
{
    class DataManager
    {
        public static List<Alarm> Alarms = new List<Alarm>();
        public static List<Schedule> Schedules = new List<Schedule>();

        static DataManager()
        {
            Load();
        }
        
        public static void Load()
        {

        }
    }
}
