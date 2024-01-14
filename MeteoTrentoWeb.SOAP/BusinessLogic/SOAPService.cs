using System.ServiceModel;
using MeteoTrentoWeb.Modelli;
using Newtonsoft.Json;


namespace MeteoTrentoWeb.SOAP.BusinessLogic;

[ServiceContract]
public interface ISOAPService
{
    [OperationContract]
    Giorni OttieniPrevisione(string data);
}

public class SoapService : ISOAPService
{
    public Giorni OttieniPrevisione(string data)
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
                    foreach (var previsione in modello.previsione)
                    {
                        return previsione.giorni.First(giorni => giorni.giorno.Equals(data));
                    }
                }
            }
        }
        return null;
    }
}