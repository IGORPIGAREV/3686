// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int FirstSide =ReadInt("Введите размер первой стороны триугольника :");
int SecondSide =ReadInt("Введите размер первой стороны триугольника :");
int ThirdSide =ReadInt("Введите размер первой стороны триугольника :");
if (FirstSide>SecondSide+ThirdSide||SecondSide>FirstSide+ThirdSide||ThirdSide>SecondSide+FirstSide)
{
    Console.WriteLine("Таким триуголиником быть нельзя.");
}
else Console.WriteLine("Мы соизволяем треугольнику с такими сторонами существовать...");  
