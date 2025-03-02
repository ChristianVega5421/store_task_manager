using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager_netcore.models
{
    public class Config
    {
        public const string section = "Server";

        public string Host { get; set; } = String.Empty;
        public string Port { get; set; } = String.Empty;
    }
}
