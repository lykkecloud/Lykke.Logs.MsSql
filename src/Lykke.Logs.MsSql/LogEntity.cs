﻿using System;
using Lykke.Logs.MsSql.Interfaces;

namespace Lykke.Logs.MsSql
{
    public class LogEntity : ILogEntity
    {
        public DateTime DateTime { get; set; }
        public string Level { get; set; }
        public string Env { get; set; }
        public string AppName { get; set; }
        public string Version { get; set; }
        public string Component { get; set; }
        public string Process { get; set; }
        public string Context { get; set; }
        public string Type { get; set; }
        public string Stack { get; set; }
        public string Msg { get; set; }
    }
}
