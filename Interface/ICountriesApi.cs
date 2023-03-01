using CountriesAPI.Models;
using Refit;

namespace CountriesAPI.Abstraction;

public interface ICountriesApi
{
    [Get("/v2/regionalbloc/eu")]
    Task<List<CountryModel>> GetCountries();

    [Get("/v2/name/{name}")]
    Task<List<CountryModel>> GetCountryByName(string name);
}