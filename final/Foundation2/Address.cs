public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        string[] possibilities = { "United States of America", "United States", "USA", "US" };

        return possibilities.Contains(_country);
    }

    public string GetAddressString()
    {
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }
}