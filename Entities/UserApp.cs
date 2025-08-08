// Entity Framework (EF) ==> it dose  mapp your application's data models to your database

using System;

namespace API.Entities;

public class AppUser
{
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    // required keyword ==> t's used to enforce initialization of properties and fields within a class, record, or struct.  
    public required string? DisplayName { get; set; } = "";

    public required string? Email { get; set; } = "";

}

// later i will add more code to it after i read more about "EF"