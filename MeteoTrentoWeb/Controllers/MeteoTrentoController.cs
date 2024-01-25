using Microsoft.AspNetCore.Mvc;
using MeteoTrentoWeb.Modelli;
using MeteoTrentoWeb.ViewModel;
using Newtonsoft.Json;

namespace MeteoTrentoWeb.Controllers;

public class MeteoTrentoController : Controller
{

    private RootObject CaricaDati()
    {
        string uri = "https://www.meteotrentino.it/protcivtn-meteo/api/front/previsioneOpenDataLocalita?localita=TRENTO";
        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage response = client.GetAsync(uri).Result)
            {
                using (HttpContent content = response.Content)
                {
                    string result = content.ReadAsStringAsync().Result;
                    RootObject modello = JsonConvert.DeserializeObject<RootObject>(result);
                    return modello;
                }
            }
        }
    }
    
    public IActionResult Index()
    {
        RootObject modello = this.CaricaDati();
        MeteoTrentoIndexViewModel vm = new MeteoTrentoIndexViewModel(modello);
        return View(vm);
    }
}