// Лукьянов Глеб 22-ИСП-2\1 Вариант:2 Уровень:Высокий 
Console.Write("Введите скорость ветра в м/с");
int speed = int.Parse(Console.ReadLine());

if (speed <= 4)
{
    Console.WriteLine("Уровень ветра - слабый");

}
else if (speed <= 10)
{
    Console.WriteLine("Уровень ветра - умеренный");

}
else if (speed <= 11)
{
    Console.WriteLine("Уровень ветра - сильный");
}
else
{
    Console.WriteLine("Уровень ветра - ураган");
}