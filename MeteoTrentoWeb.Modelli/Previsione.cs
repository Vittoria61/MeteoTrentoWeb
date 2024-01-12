namespace MeteoTrentoWeb.Modelli;

public class Previsione
{
    public string localita { get; set; }
    public int quota { get; set; }
    public Giorni[] giorni { get; set; }
}