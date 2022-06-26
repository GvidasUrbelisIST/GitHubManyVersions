using System.Diagnostics;
class Program
{
    public void skaiciavimas(double f1 = 1, double f2 = 2, double f3 = 0, int k = 0, int n = 0)
    {


        Console.WriteLine("Pirminiai skaičiai: " + f1 + " " + f2);


        while (k < 1)
        {
            f3 = f1 * f2;
            if (f3 < Math.Pow(10, 15))
            {
                f1 = f2;
                f2 = f3;
                n++;
            }
            else
            {
                k++;
                break;
                n++;
            }
        }
        Console.WriteLine("Kiek kartų seka įvyko: " + n);
        Console.WriteLine("Gautas skaičius: " + f3);
    }
}


class main
{
    public static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        Thread.Sleep(5000);
        stopwatch.Stop();

        TimeSpan ts = stopwatch.Elapsed;

        Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                        ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        Program ats = new Program();
        ats.skaiciavimas();
    }
}
