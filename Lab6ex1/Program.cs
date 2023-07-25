
using Lab6ex1;


/* Ex 1
Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul.*/

//Instantiem un dulap

Dulap dulap = new Dulap(10,5,10);

//apelam metoda

int volum = dulap.CalculeazaVolum();

Console.WriteLine( "Volumul dulapului este: " + volum);
