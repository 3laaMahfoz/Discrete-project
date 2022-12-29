
// find prime number
 Console.WriteLine("please enter the start number :");

int first = int.Parse(Console.ReadLine());

Console.WriteLine("please enter the end number :");

int end = int.Parse(Console.ReadLine());

 Boolean f = true;

for (int i = first; i < end; i++)
{
    for (int j = 2; j < i; j++) 
    {
        if (i % j == 0)
        {
            f = false;
            break;
        }
        else
        {
            f = true;
            continue;
        }
    }
    if (f == true)
        Console.WriteLine("the prime number is for your range is " );
    Console.WriteLine(i);
}

