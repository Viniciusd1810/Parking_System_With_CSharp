Console.WriteLine("Welcome to the parking system");
Console.WriteLine("Enter the Initial price:");
double initialPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the price per hour:");
double hourPrice = Convert.ToDouble(Console.ReadLine());
double timeOfStay;

int operation;
bool systemOn = true;
List<string> carList = new List<string>();

void PrintCars(List<string> carList)
{
    Console.WriteLine("List of vehicles:");
    int contador = 1;
    carList.ForEach(car =>
    {
        Console.WriteLine($"{contador}-{car}");
        contador++;
    });
}

void CheckOut()
{
    Console.WriteLine("Enter the Time of Stay");
    double timeOfStay = Convert.ToDouble(Console.ReadLine());
    double total = initialPrice + (hourPrice * timeOfStay);
    Console.WriteLine($"Total: R${total:F2}");
}

while (systemOn == true)
{
    Console.WriteLine(@"
    Enter your option:
    1- Register new vehicle
    2- Remove vehicle
    3- List vehicle 
    4- Shut down");

    operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Console.WriteLine("Enter the Vehicle Number Plate");
            string input = Console.ReadLine();
            carList.Add(input);
            break;

        case 2:
            PrintCars(carList);
            Console.WriteLine("Enter which vehicle will be removed");
            int indexReal = Convert.ToInt32(Console.ReadLine()) - 1;
            CheckOut();
            carList.RemoveAt(indexReal);
            break;

        case 3:
            PrintCars(carList);
            break;

        case 4:
            Console.WriteLine("Ending program...");
            systemOn = false;
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}
