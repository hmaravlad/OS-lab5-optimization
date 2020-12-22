
class App
    {

static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[,] a = new int[10000,10000];
            int res = 0;
            
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                        a[j,i]++;
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs);
        }

    }