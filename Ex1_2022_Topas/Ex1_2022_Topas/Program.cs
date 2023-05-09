int P = 0;
string[] HAR = Console.ReadLine().Split(' ');
string[] KAR = Console.ReadLine().Split(' ');

int HA = int.Parse(HAR[0]);
int HR = int.Parse(HAR[1]);

int KA = int.Parse(KAR[0]);
int KR = int.Parse(KAR[1]);

if ((HA >= 1 && HA <= 100) && (KA >= 1 && KA <= 100) && (KA >= 1 && KA <= 500) && (KR >= 1 && KR <= 500))
{

    if ((HA > KA && HR > KR) || (HA == KA && HR > KR))
    {
        P = (HA - KA) + (HR - KR);
    }
    else if (HA < KA && HR > KR)
    {
        P = (KA - HA) + (HR - KR);
    }
    else if ((HA > KA && HR < KR) || (HA == KA && HR < KR))
    {
        P = (HA - KA) + (KR - HR);
    }
    else if (HA > KA && HR > KR)
    {
        P = (HA - KA) + (KR - HR);
    }
}
Console.WriteLine(P.ToString());
Console.ReadLine();



