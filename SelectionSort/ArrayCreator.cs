/// <summary>
/// Класс, отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateOneDimensionArray(this int n)
    {
        return new int[n];
    }
    /// <summary>
    /// Выводит массив в строку
    /// </summary>
    /// <param name="array"></param>
    /// <returns>Строка с представлением массива</returns>
    public static string ConvertToStringAndprintToTerminal(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        System.Console.WriteLine(str);
        return str;
    }
    /// <summary>
    /// Заполняет массив значениями от min до max
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапазона генераторв случайных чисел</param>
    /// <param name="max">Верхняя граница диапазона генераторв случайных чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return array.Select(item => Random.Shared.Next(min, max)).ToArray();
    }
}
