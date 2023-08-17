using System;

namespace Skarp.HubSpotClient.Company
{
    public class EngagementRecentRequestOptions
    {
        private int _count = 10;
        private long? _since;

        public int NumberOfCount
        {
            get => _count;
            set
            {
                if (value < 1 || value > 250)
                {
                    throw new ArgumentException(
                        $"Number of companies to return must be a positive integer greater than 0 and less than 251 - you provided {value}");
                }
                _count = value;
            }
        }

        public void SetSince(DateTime since)
        {
            _since = (int)since.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public long? Since
        {
            get => _since;
        }

    }
}
