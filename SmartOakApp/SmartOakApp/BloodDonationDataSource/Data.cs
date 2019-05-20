using System;
using System.Collections.Generic;
using System.Text;
using SmartOakApp.BloodDonation;
namespace SmartOakApp.BloodDonationDataSource
{
    public class Data
    {
        List<BloodEntry> bloodEntries = new List<BloodEntry>();

        public Data()
        {
            bloodEntries.Add(new BloodEntry(22, DateTime.Now));
            bloodEntries.Add(new BloodEntry(450, DateTime.Now));
        }

    }
}
