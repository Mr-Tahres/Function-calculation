Console.Write("1. SAYIYI GİRİNİZ: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("2. SAYIYI GİRİNİZ: ");
int m = Convert.ToInt32(Console.ReadLine());

int f = 1;

int ff = 1;

for (int i = 2; i <= n; i++)
{
    f *= i;

    Console.WriteLine("{0}! = {1}", n, f);
}

float x = f;

for (int i = 2; i <= m; i++)
{
    ff *= i;

    Console.WriteLine("{0}! = {1}", m, ff);
}
float y = ff;

float islem = x/y;

Console.Write($"İŞLEM: {x}/{y} = "+ islem);
