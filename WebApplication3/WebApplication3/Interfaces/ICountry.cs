﻿using WebApplication3.Models;

namespace WebApplication3.Interfaces
{
    public interface ICountry
    {
        ICollection<Country> GetCountries();

    }
}
