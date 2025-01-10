int hp = 10;






static void Ritahp(int hp)
{

    System.Console.Write("[");
    for (int i = 0; i < hp; i++)
    {
        System.Console.Write("=");
    }
    System.Console.WriteLine("]");
}


while (hp > 0)
{
    Ritahp(hp);
    hp--;
}


Console.ReadLine();