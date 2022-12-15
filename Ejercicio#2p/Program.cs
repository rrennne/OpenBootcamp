//EJERCICIO TEMA #4

internal class Program
{
    private static void Main(string[] args)
    {
        int numerolf = 4;
        int numeroWhile = 0;
        int numeroFor;
        int estacion = 3;

        //Vemos si numerolf es positivo o negativo
        System.Console.WriteLine("Es positivo o no?");
        if (numerolf > 0)
        {
            System.Console.WriteLine("El número es positivo");
        }
        else
        {
            System.Console.WriteLine("El número es negativo");
        }
        System.Console.WriteLine("\n");
        // fin de esta estructura.

        //Incrementa el valor y lo imprime
        System.Console.WriteLine("While");
        while (numeroWhile < 3)
        {
            numeroWhile++;
            System.Console.WriteLine(numeroWhile);
        }
        System.Console.WriteLine("\n");
        // fin de esta estructura


        //Este do While solo se ejecuta Una vez
        System.Console.WriteLine("do While");
        do
        {
            numeroWhile = 0; //Lo vuelvo iniciar a 0, para cuando sea 1, ya salga del do While.
            numeroWhile++;
            System.Console.WriteLine(numeroWhile);
        } while (numeroWhile == 0);
        System.Console.WriteLine("\n");
        //fin de esta estructura.


        //Este For se ejecuta asta que sea igual o menor a 3
        System.Console.WriteLine("For");
        for (numeroFor = 0; numeroFor <= 3; numeroFor++)
        {
            System.Console.WriteLine(numeroFor);
        }
        System.Console.WriteLine("\n");
        //fin de esta estructura.


        //Este es un Switch nos dice en que estación del año estamos estacion = 3. (Otoño)
        System.Console.WriteLine("switch");
        switch (estacion)
        {
            case 1:
            System.Console.WriteLine("Estas en Primavera");
            break;

            case 2:
            System.Console.WriteLine("Estas en Verano");
            break;

            case 3:
            System.Console.WriteLine("Estas en Otoño");
            break;

            case 4:
            System.Console.WriteLine("Estas en Invierno");
            break;

            default:
            System.Console.WriteLine("Esta no es una estación del año");
            break;
        }
        //fin de esta estructura.
    }
}
