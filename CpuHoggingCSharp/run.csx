using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    var start = DateTime.Now;
    log.Verbose($"C# started: {DateTime.Now}");    
    var end = DateTime.Now + TimeSpan.FromSeconds(50);
    long loop = 0;
    while (DateTime.Now < end)
    {
        if (++loop % 100000 == 0)
        {
           log.Verbose($"C# Timer trigger function loop: {loop:N0}");    
        }
        // no-op
    }
    log.Verbose($"C# finished: {DateTime.Now}");    
}