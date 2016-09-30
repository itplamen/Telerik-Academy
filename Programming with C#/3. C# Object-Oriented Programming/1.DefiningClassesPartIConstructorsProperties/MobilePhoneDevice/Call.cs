using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Call
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int duration;

        //Constructors
        public Call(DateTime dateTime, string dialedPhoneNumber, int duration)
        {
            this.dateAndTime = dateTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        //Properties
        public DateTime DateAndTime 
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return dialedPhoneNumber; }
            set { dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
