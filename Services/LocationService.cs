namespace MitchellFabrication.Services;

using MitchellFabrication.Models;

public class LocationService
{
    private readonly HttpClient _http;
    private readonly PersonalInfo _personal;

    public record StateModel(string Name, string Iso2);
    public record CityModel(string Name);

    public List<StateModel> States { get; } = new()
    {
        new("Alabama",        "AL"), new("Alaska",         "AK"), new("Arizona",       "AZ"),
        new("Arkansas",       "AR"), new("California",     "CA"), new("Colorado",      "CO"),
        new("Connecticut",    "CT"), new("Delaware",       "DE"), new("Florida",       "FL"),
        new("Georgia",        "GA"), new("Hawaii",         "HI"), new("Idaho",         "ID"),
        new("Illinois",       "IL"), new("Indiana",        "IN"), new("Iowa",          "IA"),
        new("Kansas",         "KS"), new("Kentucky",       "KY"), new("Louisiana",     "LA"),
        new("Maine",          "ME"), new("Maryland",       "MD"), new("Massachusetts", "MA"),
        new("Michigan",       "MI"), new("Minnesota",      "MN"), new("Mississippi",   "MS"),
        new("Missouri",       "MO"), new("Montana",        "MT"), new("Nebraska",      "NE"),
        new("Nevada",         "NV"), new("New Hampshire",  "NH"), new("New Jersey",    "NJ"),
        new("New Mexico",     "NM"), new("New York",       "NY"), new("North Carolina","NC"),
        new("North Dakota",   "ND"), new("Ohio",           "OH"), new("Oklahoma",      "OK"),
        new("Oregon",         "OR"), new("Pennsylvania",   "PA"), new("Rhode Island",  "RI"),
        new("South Carolina", "SC"), new("South Dakota",   "SD"), new("Tennessee",     "TN"),
        new("Texas",          "TX"), new("Utah",           "UT"), new("Vermont",       "VT"),
        new("Virginia",       "VA"), new("Washington",     "WA"), new("West Virginia", "WV"),
        new("Wisconsin",      "WI"), new("Wyoming",        "WY"),
    };
    public List<CityModel> Cities { get; private set; } = new();
    public bool CitiesAvailable { get; private set; } = true;

    public LocationService(HttpClient http, PersonalInfo personal)
    {
        _http = http;
        _personal = personal;
    }

    public async Task LoadCities()
    {
        var state = _personal.FormValues["state"];
        if (string.IsNullOrEmpty(state)) return;
        Cities.Clear();
        CitiesAvailable = true;
        try
        {
            var response = await _http.GetFromJsonAsync<List<CityModel>>(
                $"https://api.countrystatecity.in/v1/countries/US/states/{state}/cities");
            Cities = response ?? new();
        }
        catch
        {
            CitiesAvailable = false;
        }
    }
}
