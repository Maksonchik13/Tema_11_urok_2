Console.WriteLine("Введите температуру ");
int t=int.Parse(Console.ReadLine());
if (t == 20) Console.WriteLine("Можно выпустить кенгуру");
else if (t < 20 && t >= -20) Console.WriteLine("Можно выпустить волков, медведей и пингвинов");
else if (t > 20 && t <= 40) Console.WriteLine("Можно выпустить львов, жирафов и слонов");
else Console.WriteLine("Никого нельзя выпускать!");