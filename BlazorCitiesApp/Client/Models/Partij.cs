namespace BlazorCitiesApp.Client.Models
{
    public class Partij
    {
        public int PartijID { get; set; }
        public string? Naam { get; set; }
        public string? VolledigeNaam { get; set; }
        public int Zetels { get; set; }

        // Deze property zit niet in de Web API data maar wordt straks door de gebruiker gezet
        public bool InCoalitie { get; set; } = false;
    }
}
