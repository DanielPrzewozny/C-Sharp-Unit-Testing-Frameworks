using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._2___TheOldestOne;
public class UserDataBase
{
    public readonly List<User> Users;

    public UserDataBase()
    {
        Users = new List<User>()
        {
            new User(name: "John", surname: "Kind", dateOfBirth: new DateTime(2000, 1, 12)),
            new User(name: "Martha", surname: "Sand", dateOfBirth: new DateTime(1995, 2, 24)),
            new User(name: "Daniel", surname: "Main", dateOfBirth: new DateTime(1994, 3, 13)),
            new User(name: "Pablo", surname: "Pavo", dateOfBirth: new DateTime(1978, 4, 3)),
            new User(name: "Kriss", surname: "Wron", dateOfBirth: new DateTime(1940, 5, 5)),
            new User(name: "Ola", surname: "Dnulgne", dateOfBirth: new DateTime(1983, 6, 8)),
        };
    }
}
