Banca banca = new Banca();

Utente Utente = new Utente();

Prestito Prestito = new Prestito();

//Creazione utente dinamico
Utente.Nome = Console.ReadLine();
Utente.Cognome = Console.ReadLine();
Utente.CodiceFiscale = Console.ReadLine();
Utente.Stipendio = Convert.ToInt32(Console.ReadLine());

//Creazione prestito dinamico
Prestito.ID = Convert.ToInt32(Console.ReadLine());
Prestito.Utente = 
Prestito.Ammontare = Convert.ToInt32(Console.ReadLine());
Prestito.Rata = Convert.ToInt32(Console.ReadLine());
Prestito.DataInizio = DateOnly.Parse(Console.ReadLine());
Prestito.DataFine = DateOnly.Parse(Console.ReadLine());