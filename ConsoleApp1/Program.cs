Console.WriteLine("Podaj a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj b: ");
int b = int.Parse(Console.ReadLine());
bool kontynuj = true;

while (a != b & kontynuj == true)
{
    if (a >= b)
    {
        a -= b;
        kontynuj = true;
        //Console.WriteLine("a jest wieksze od b:      A:" + a + "  B: " + b);
    }
    else
    {
        b -= a;
        kontynuj = true;
        //Console.WriteLine("b jest wieksze od a:      A:" + a + "  B: " + b);
    }
}
while (a == b & kontynuj == true)
{
    Console.WriteLine("a jest równe: " + a);
    kontynuj = false;
}
