﻿using System;

namespace Luna.Clients.Azure.APIM
{
    public class APIMConfigurationOption
    {
        public APIMConfiguration Config { get; set; }
    }

    public class APIMConfiguration
    {
        public Guid SubscriptionId { get; set; }
        public string ResourceGroupname { get; set; }
        public string APIMServiceName { get; set; }
        public string Token { get; set; }
    }
}
