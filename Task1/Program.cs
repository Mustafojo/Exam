int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int cnt = 0;
for(int i = 0;i < a;i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0;i < a-1;i++)
{
    cnt = 0;
    for(int j = 0;j < a;j++)
        if(arr[i] != arr[j])
        {
           cnt++;
        }
  
}
Console.WriteLine(cnt);
