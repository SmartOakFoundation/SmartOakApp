using System;
using System.Collections.Generic;
using System.Text;

namespace SmartOakApp.BloodDonation
{
    class BloodEntry
    {
        private int _amount;
        private DateTime _date;

        public int Amount
        {
            get { return _amount; }
            set { if(value < Int32.MaxValue && value > 0) { _amount = value; } }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public BloodEntry(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
