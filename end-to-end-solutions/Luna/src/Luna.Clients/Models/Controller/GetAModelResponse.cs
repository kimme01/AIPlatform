﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Luna.Clients.Models.Controller
{
    public class GetAModelResponse
    {
        public string modelId { get; set; }
        public string status { get; set; }
        public string startTimeUtc { get; set; }
        public string completeTimeUtc { get; set; }
<<<<<<< HEAD
        public string description { get; set; }
=======
        public String description { get; set; }
        public object error { get; set; }
>>>>>>> da4b2c65940595bb6b515ccf1074cf8c7581d669
    }
}
