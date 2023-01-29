{
    Random random = new Random();

    // Создадим массив произвольной длины, заполним и выведем
    int[] Values = new int[10];
    Console.WriteLine("Значения массива: ");
    for (int i = 0; i < Values.Length; i++)
    {
        Values[i] = random.Next(0, 100);
        Console.Write(i + 1 + ") " + Values[i] + "\t");
    }

    // Найдем разницу Max и Min значений
    int result = Math.Abs(Values.Max()) - Math.Abs(Values.Min());
    // Модуль на тот случай если Вы захотите использовать и отрицательные значения

    // Осуществляем проверку истинности нашего утверждения
    if (result < 25) { Console.WriteLine("Утверждение верно"); }
    else { Console.WriteLine("Утверждение ложно"); }
    Console.ReadKey();
}
