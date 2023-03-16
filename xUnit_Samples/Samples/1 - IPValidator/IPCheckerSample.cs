using System;
using System.Threading.Channels;

namespace Samples._1___IPValidator;

public static class IPCheckerSample
{
    public static void CheckIp()
    {
        string[] ips = new string[4] { "192.168.2.5", "172.15.5.1", "2001:0db8:85a3:0000:0000:8a2e:0370:7334", "192.ABCD.168.2.5" };

        foreach (var ip in ips)
            Console.WriteLine($"{(ip.IsIPv4Address() ? $"{ip} is IPv4 address"
                : ip.IsIPv6Address() ? $"{ip} is IPv6 address" : $"{ip} is not ip address")}"); 
    }
}
