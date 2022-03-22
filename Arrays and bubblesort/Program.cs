int [] arr = new int [100];

Random random = new Random ();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(600);

    
}


for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < (arr.Length - 1) - i; j++)
        
    {
        
        if (arr[j] > arr[j+1])
        {
            int placeholder = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = placeholder;
        }
    }
   
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


Console.ReadKey();