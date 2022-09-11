// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double [] PointIntersectionLine(int b1, int k1, int b2, int k2 )
{
    int znachenie1 = 1;
    int znachenie2 = 1;
    znachenie1 = (k1 - k2)*-1; // Вычитаем из первого уравнения второе. Умножаем на -1 для замены знака после раскрытия скобок
    znachenie2 = (b1 - b2); // Вычитаем из первого уравнения второе.
    double x =1.0; 
    x = (znachenie2 / (float) znachenie1 ); // Переводим дробь в десятичное число, используем (float) чтобы деление выполнялось с остатком
    double y =1.0;
    y = k2 * (x) + b2; // Подставляем значение (х) во второе уравнение
    double [] array;
    array = new double [] {x, y};
    return array; 
   
}
double [] x = PointIntersectionLine(2, 5, 4, 9 );
Console.Write($"Точка пересечения двух прямых имеет координаты: {x [0]}; ");
Console.Write(x [1]);
