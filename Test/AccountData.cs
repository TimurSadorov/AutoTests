﻿namespace Test;

public class AccountData
{
    public AccountData(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}