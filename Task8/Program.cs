void www( int a,  int b)
{
    Console.WriteLine(a = b);
   
}
void wow(int a,  int b)
{
     Console.WriteLine(b = a);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("A = ");
www( a , b);
Console.Write("B = ");
wow( a , b);
