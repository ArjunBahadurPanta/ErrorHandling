double speed;


try
{
    Console.Write("Enter distance: ");
    int distance = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter time: ");
    int time = Convert.ToInt32(Console.ReadLine());

    speed = distance / time;

}

catch(Exception ex)
{
        Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

}