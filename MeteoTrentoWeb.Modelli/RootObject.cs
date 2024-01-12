namespace MeteoTrentoWeb.Modelli;

public class RootObject
{
    public string fonte_da_citare { get; set; }
    public string codice_ipa_titolare { get; set; }
    public string nome_titolare { get; set; }
    public string codice_ipa_editore { get; set; }
    public string nome_editore { get; set; }
    public string dataPubblicazione { get; set; }
    public int idPrevisione { get; set; }
    public string evoluzione { get; set; }
    public string evoluzioneBreve { get; set; }
    public object[] AllerteList { get; set; }
    public Previsione[] previsione { get; set; }
}
