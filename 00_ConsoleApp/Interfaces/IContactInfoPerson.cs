﻿using _00_ConsoleApp.Models;

namespace _00_ConsoleApp.Interfaces;

internal interface IContactInfoPerson
{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }
    string Address { get; set; }

}
