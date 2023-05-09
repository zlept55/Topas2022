int F = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

bool m = false;
int[] e = new int[N];
int cont = 0,maior = 0;
for (int i = 0; i < N; i++)
{
    e[i] = Convert.ToInt32(Console.ReadLine());
    if (e[i] > F)
    {
        cont++;
        if (cont == N)
        {
            Console.WriteLine("No free lunch");
            m = false;
        }
    }
    else if (e[i] > maior)
    {
        maior = e[i];
        m = true;
    }
}
if(m == true)
{
    Console.WriteLine(maior);
}
Console.ReadLine();



