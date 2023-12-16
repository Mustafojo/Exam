int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int cnt = 0;
for(int i = 0;i < a;i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int b = Convert.ToInt32(Console.ReadLine());
for(int i = 0;i < a;i++)
{
   if(arr[i] == b)  
   {
    cnt++;
   }

}
Console.WriteLine(cnt);
