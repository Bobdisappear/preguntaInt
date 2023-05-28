

Console.WriteLine("Introduce tu edad");

string Age = Console.ReadLine();

int myAge = Convert.ToInt32(Age);
int votingAge = 18;


if (myAge >= votingAge)
{
    Console.WriteLine("Enhorabuena puedes votar");

}
else
{
    Console.WriteLine("Al chikipark chaval");
}


int time = 20;
if (time < 18)
{
    Console.WriteLine("Buenos dias");

}
else
{
    Console.WriteLine("Buenas noches");
}

//Short Hand Ternary

int bye = 20;
string result = (bye < 18) ? "Hola otra vez" : "Nos vemos";
Console.WriteLine(result);




int day = 3;

switch (day)
{
    case 1: Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;

}

//Loop ForEach

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars);
foreach (string car in cars)

{
    Console.WriteLine(car);
}