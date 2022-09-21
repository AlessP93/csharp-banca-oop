
//1 La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)

public class Banca
{
    public string Nome { get; set; }

    List<Utente> Utenti = new List<Utente>();

    List<Prestito> Prestiti = new List<Prestito>();

    public Banca(string nome)
    {
        Nome = nome;

    }

    //4 Per la banca deve essere possibile
    //sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
    //sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
    //Per i clienti si vuole stampare un prospetto con tutti i dati che li caratterizzano in un formato di tipo stringa
    public void AggModRicerca(Utente utente) //aggiungere, modificare e ricercare un cliente.
    {
        Utenti.Add(utente);
    }
    public void AggPrestito(Prestito prestito) //aggiungere un prestito.
    {
        Prestiti.Add(prestito);
    }

    //effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
    public List<Prestito> CercaPrestiti(string CodiceFiscale)
    {
        List<Prestito> risultati = new List<Prestito>();
        {
            foreach (Prestito prestito in Prestiti)
            {
                if (prestito.utente.CodiceFiscale.Contains(CodiceFiscale))
                {
                    Prestiti.Add((Prestito)prestito);
                }
            }
        }
        return Prestiti;
    }
}
     
    

