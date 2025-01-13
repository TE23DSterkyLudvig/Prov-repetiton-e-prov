string hp;
int hptal;


while(true){
   System.Console.WriteLine("Skriv ett Hp mellan 1 och 20.");
 hp = Console.ReadLine();
int.TryParse(hp, out hptal); 

if( int.TryParse(hp, out hptal ) == false){
    System.Console.WriteLine("Skriv ett nytt tal som inte är bokstav");
    Thread.Sleep(800);
}
else if(hptal > 20 || hptal < 1){
    System.Console.WriteLine("Skriv ett tal mellan 1 och 20");
    Thread.Sleep(800);
}
else{
    break;
}
}



static void Ritahp(int hp)
{

    System.Console.Write("[");
    for (int i = 0; i < hp; i++)
    {
        System.Console.Write("=");
    }
    System.Console.WriteLine("]");
}


while (hptal > 0)
{
    Ritahp(hptal);
    hptal--;
}
System.Console.WriteLine("död");


Console.ReadLine();