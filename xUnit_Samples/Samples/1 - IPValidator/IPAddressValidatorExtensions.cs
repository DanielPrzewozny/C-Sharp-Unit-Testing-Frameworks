using System.Net;
using System.Net.Sockets;

namespace Samples._1___IPValidator;

public static class IPAddressValidatorExtensions
{
    public static bool IsIPv4Address(this string input)
        => !IPAddress.TryParse(input, out IPAddress address) || string.IsNullOrEmpty(input)
        ? false
        : address.AddressFamily is AddressFamily.InterNetwork ? true : false;

    public static bool IsIPv6Address(this string input)
        => !IPAddress.TryParse(input, out IPAddress address) || string.IsNullOrEmpty(input)
        ? false
        : address.AddressFamily is AddressFamily.InterNetworkV6 ? true : false;
}
