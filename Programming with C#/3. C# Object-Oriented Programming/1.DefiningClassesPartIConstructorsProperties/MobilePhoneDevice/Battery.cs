using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Battery
    {
        //Enumeration
       public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        //Fields
        private BatteryType batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;

        //Constructors
        public Battery(BatteryType batteryModel, int batteryHoursIdle, int batteryHoursTalk)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
        }

        //Properties
        public BatteryType BatteryModel 
        {
            get { return batteryModel; }
        }

        public int BatteryHoursIdle 
        {
            get { return batteryHoursIdle; }
            set { batteryHoursIdle = value; }
        }

        public int BatteryHoursTalk 
        {
            get { return batteryHoursTalk; }
            set { batteryHoursTalk = value; }
        }
    }
}