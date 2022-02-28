﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HltvApi.Models
{
    public class RecentMatchItem
    {
        public string date { get; set; }
        public DateTime DateTime { get; set; }
        public string team1name { get; set; }
        public string team2name { get; set; }

        public int team1id { get; set; }
        public int team2id { get; set; }
        public string team1iconurl { get; set; }
        public string team2iconurl { get; set; }

        public int team1Score { get; set; }
        public int team2Score { get; set; }

    }
}
