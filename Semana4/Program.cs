using Semana4;

Contar_Caracteres letras = new Contar_Caracteres();

Console.WriteLine("Ingresa los caracteres que desees");

string Texto = Console.ReadLine();

int numeros = letras.Letras(Texto);

Console.WriteLine("La cantidad de caracteres de tu texto es de " + numeros);