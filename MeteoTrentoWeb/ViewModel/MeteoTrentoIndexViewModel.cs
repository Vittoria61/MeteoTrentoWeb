using MeteoTrentoWeb.Modelli;

namespace MeteoTrentoWeb.ViewModel;

public class MeteoTrentoIndexViewModel
{
    public RootObject modello { get; set; }

    public MeteoTrentoIndexViewModel(RootObject modello)
    {
        this.modello = modello;
    }
}