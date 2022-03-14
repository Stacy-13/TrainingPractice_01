class Program
{
    public static void Main()
    {
        int gold, val = 20, crystal, lasted;
        Console.WriteLine("Введите количество золота");
        try
        {
            gold = int.Parse(Console.ReadLine());
            Console.Write("Сколько кристаллов желаете приобрести: \n");
            crystal = int.Parse(Console.ReadLine());
            while (gold > 0 && gold > crystal * val && crystal > 0) 
            { 
                lasted = gold - crystal * val;
                Console.WriteLine("Вы приобрели {0} кристалл(ов) \nУ вас осталось {1} золота", crystal, lasted);
                break;
            }
            while(gold < 0 || crystal < 0 || gold < crystal * val)
            {
                Console.WriteLine("Вы не можете приобрести кристаллы. У вас недостаточно средств. Цена составляет {0} золотых", val);
                break;
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Не правильный ввод");
        }
        /*catch ()
        {

        }
        finally
        {

        }*/
    }
}