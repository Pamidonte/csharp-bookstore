// See https://aka.ms/new-console-template for more information
string titolo = "--------IL LIBRO DI OGGI: CodePen di Robert C.--------";
long isbn = 9780132350884;
int numeroDellePagine = 431;
int pesoDelLibro = 800;
float larghezza = 17.7f;
float lunghezza = 2.7f;
float profondita = 23.3f;
int numeroRecensioni = 4571;
float valutazioneMedia = 4.5f;
string kindleDisponibile = "si";
string copertinaFlessibile = "si";




Console.WriteLine(titolo);
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: "+ isbn);
Console.WriteLine("Numero delle pagine: " + numeroDellePagine + " Pagine");
Console.WriteLine("Peso del libro: " + pesoDelLibro +" g");
Console.WriteLine("Dimensioni: " + larghezza + "x" + lunghezza + " x " + profondita + " cm");
Console.WriteLine("");

Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni);
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelle");
Console.WriteLine("Kindle disponibile: " + kindleDisponibile);
Console.WriteLine("Copertina flessibile disponibile: " + copertinaFlessibile);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");