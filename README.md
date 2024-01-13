# ST1417 App Cloud - Progetto Esame

### Progetto 2: ASP.NET Core MVC
Sviluppare un’applicazione web in grado di visualizzare il bollettino meteo della provincia di Trento:
- Leggere il servizio REST JSON messo a disposizione dalla regione Trentino Alto Adige;
- Visualizzare i dati in una interfaccia web (sfruttando anche immagini fornite dal servizio nell’interfaccia grafica)
- Creare un WS SOAP che faccia da «convertitore», convertendo servizio REST JSON in uno SOAP, e permetta di ricercare il meteo per uno specifico giorno
- Far funzionare l’applicativo in un container Docker

> Servizio: https://dati.trentino.it/dataset/bollettino-meteorologico-localita/resource/ad5f9738-c63c-4efc-a375-8347e5d480c8

> JSON: https://www.meteotrentino.it/protcivtn-meteo/api/front/previsioneOpenDataLocalita?localita=TRENTO

### Soluzioni
- [MeteoTrentoWeb](MeteoTrentoWeb): applicazione MVC che visualizza i dati caricati dal servizio in una interfaccia web
- [MeteoTrento.SOAP](MeteoTrentoWeb.SOAP): servizio SOAP che converte il servizio REST JSON in SOAP con funzionalità per ottenere il meteo di uno specifico giorno
- [MeteoTrento.Modelli](MeteoTrentoWeb.Modelli): modelli dei dati comuni alle soluzioni

### Docker
Il file [docker-compose.yml](docker-compose.yml) definisce la composizione dei due servizi in un singolo container Docker.