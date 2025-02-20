Console.WriteLine("Napishete kolko pari imate");
double money = double.Parse(Console.ReadLine());
Console.WriteLine("Napishete kolko kutii kucheshka hrana ste kupili");
int dogfood = int.Parse(Console.ReadLine());
Console.WriteLine("Napishete kolko kutii koteshka hrana ste kupili");
int catfood = int.Parse(Console.ReadLine());


double dogfoodprice = 2.50;
double catfoodprice = 4.00;

if (money > catfoodprice)
{
    if (money > dogfoodprice)
    {

        Console.WriteLine("Parite sa dostatuchni za kucheshka hrana");

    }
    Console.WriteLine("Parite sa dostatuchni za koteshka hrana");

}
else
{

    Console.WriteLine("Parite ne sa dostatuchni");
}



Console.WriteLine("Kucheshkata hrana struva: ");
Console.WriteLine(dogfood * dogfoodprice); 

Console.WriteLine("Koteshkata hrana struva: ");
Console.WriteLine(catfood * catfoodprice);