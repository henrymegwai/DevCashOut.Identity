﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlinkCash.Core.Configs
{
    public class AppSettings
    { 

        public string IdentityUrl { get; set; }
        public string ImageServiceUrl { get; set; }
        public bool IsSmsLive { get; set; }
        public string OtpUrl { get; set; }       
        public string NubanServiceUrl { get; set; }
        public string AppZoneApiToken { get; set; }
        public string AppZoneApiVersion { get; set; }
        public string TermiiOtpUrl { get; set; }
        public string[] CorsUrls { get; set; }
        public string SmtpUsername { get; set; }
        public string SendGridApiKey { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpHost { get; set; }
        public int ExpiredMinute { get; set; }
        public string NubanAccessKey { get; set; }
        public string SavingsServiceUrl { get; set; }
        public string BlinkCashWebUrl { get; internal set; }
    }
}
