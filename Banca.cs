Banca banca = new Banca("Bank Of America");

Utente utente = new Utente();

Prestito prestito = new Prestito();

//Creazione utente dinamico
Console.WriteLine("Benvenuto in {0} ", banca.Nome);
Console.WriteLine("Inserisci il tuo nome ");
utente.Nome = Console.ReadLine();
Console.WriteLine("Inserisci il tuo cognome ");
utente.Cognome = Console.ReadLine();
Console.WriteLine("Inserisci il tuo codice fiscale ");
utente.CodiceFiscale = Console.ReadLine();
Console.WriteLine("Inserisci il tuo stipendio ");
utente.Stipendio = Convert.ToInt32(Console.ReadLine());

//Creazione prestito dinamico
Console.WriteLine("Inserisci il ID ");
prestito.ID = Convert.ToInt32(Console.ReadLine());
prestito.Utente = utente;
Console.WriteLine("Inserisci il tuo ammontare ");
prestito.Ammontare = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci la tua rata ");
prestito.Rata = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci la data inizio rata ");
prestito.DataInizio = DateOnly.Parse(Console.ReadLine());
Console.WriteLine("Inserisci la data fine rata ");
prestito.DataFine = DateOnly.Parse(Console.ReadLine());