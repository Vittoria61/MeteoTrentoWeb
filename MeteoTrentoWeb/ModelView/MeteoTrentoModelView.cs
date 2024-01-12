using MeteoTrentoWeb.Modelli;

namespace MeteoTrentoWeb.ModelView;

public class MeteoTrentoModelView
{
    public RootObject modello { get; set; }

    public MeteoTrentoModelView(RootObject modello)
    {
        this.modello = modello;
    }
}