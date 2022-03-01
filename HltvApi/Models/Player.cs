﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HltvApi.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string playerImgUrl { get; set; }
        public string Country { get; set; }
        public string status { get; set; }
        public string timeOnTeam { get; set; }
        public int mapsPlayed { get; set; }
        public double rating { get; set; }
    }
}
