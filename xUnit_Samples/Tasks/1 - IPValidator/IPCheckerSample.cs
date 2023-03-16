using System;
using System.Net.Sockets;
using System.Net;
using System.Threading.Channels;

namespace Tasks._1___IPValidator;

public static class IPCheckerSample
{
    public static void CheckIp()
    {
        List<string> inputs = new List<string>()
        { 
            "192.168.2.5", 
            "172.15.5.1", 
            "2001:0db8:85a3:0000:0000:8a2e:0370:7334", 
            "192.ABCD.168.2.5",
            ""
        };

        foreach (var input in inputs)
            Console.WriteLine(input.SpecifyKindOfIPAddress() switch
            {
                AddressFamily.InterNetwork => $"{input} is IPv4 address",
                AddressFamily.InterNetworkV6 => $"{input} is IPv6 address",
                _ => $"{input} is not valid address"
            });
    }

    public static AddressFamily? SpecifyKindOfIPAddress(this string input)
        => IPAddress.TryParse(input, out IPAddress? address) || !string.IsNullOrEmpty(input) 
        ? (address is not null ? address.AddressFamily : AddressFamily.Unknown)
        : AddressFamily.Unknown;
}
