int E = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int[] n = new int[E];
string[] e = new string[E];
int dn = 0;

for(int i = 0; i <= N; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine().Split());
}
for(int j = 0; j <= N; j++)
{
    dn = n[j++] - n[j];
    if (dn)
    {       

    }
}
Console.ReadLine();