using MeteoTrentoWeb.Modelli;

namespace MeteoTrentoWeb.ModelView;

public class MeteoTrentoIndexViewModel
{
    public RootObject modello { get; set; }

    public MeteoTrentoIndexViewModel(RootObject modello)
    {
        this.modello = modello;
    }
}