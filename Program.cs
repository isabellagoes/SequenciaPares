int numero;
int numeroPar = 0;
 
do
{
    Console.Write("Digite um número inteiro e positivo: ");
    //numero = ConvertToInt32(Console.ReadLine());
    Int32.TryParse(Console.ReadLine(), out numero);
} 
while (numero <= 0);
 
while (numeroPar <= numero)
{
    Console.Write($"{numeroPar} ");
    numeroPar += 2;
}