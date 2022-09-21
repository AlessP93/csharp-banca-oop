
//1 La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)

//4 Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti si vuole stampare un prospetto con tutti i dati che li caratterizzano in un formato di tipo stringa

public class Banca
{
    public string Nome { get; set; }

    List<Utente> Utenti = new List<Utente>();

    List<Prestito> Prestiti = new List<Prestito>();

}
