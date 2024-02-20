
using Uni2_Speed;

Console.WriteLine("enter the distance:");
double distance = double.Parse(Console.ReadLine());
Console.WriteLine("enter the time :");
double time = double.Parse(Console.ReadLine());
Speed speed = new Speed(distance, time);
Console.WriteLine(speed.ToString());
