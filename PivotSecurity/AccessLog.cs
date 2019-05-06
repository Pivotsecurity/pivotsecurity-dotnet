using System;
using System.Collections.Generic;
using System.Text;

namespace PivotSecurity
{
    class AccessLog
    {
        string ip { get; set; }
        string browser { get; set; }
        string version { get; set; }
        string platform { get; set; }
        string language { get; set; }
        string logged { get; set; }
    }
}
