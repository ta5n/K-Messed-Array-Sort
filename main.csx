#! dotnet-script.exe

int[] inputarr ={1, 4, 5, 2, 3, 7, 8, 6, 10, 9};
int k = 2;
int[] outarr = inputarr;

int temp;
int leftend, length = inputarr.Length;


for (byte cur = 0; cur < length; cur++)
{
    leftend = (cur + k < length) ? cur + k : length - 1;
    for (int i = leftend; i > cur; i--)
    {
        if (outarr[i] < outarr[cur])
        {
            temp = outarr[cur];
            outarr[cur] = outarr[i];
            outarr[i] = temp;
        }
    }
}

foreach (var item in outarr)
{
    Console.Write(item.ToString(), " ");
}

Console.WriteLine("Hello world!");
