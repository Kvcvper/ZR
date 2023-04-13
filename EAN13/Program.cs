
Console.WriteLine("Prosze podac 13 cyfrowy numer EAN");
string? inputValue = Console.ReadLine();

if(inputValue?.Length != 13)
{
    Console.WriteLine("Podano zły format");
    Environment.Exit(1);
}

int[] validationDigits = new int[13];

for(int i = 0; i < 13; i++)
{
    if(!int.TryParse(inputValue[i].ToString(), out validationDigits[i]))
    {
        Console.WriteLine($"Literka: {inputValue[i]} nie jest cyfra");
        Environment.Exit(1);
    }
}
int sum = 0;

for(int i = 0; i < 12; i++)
{
    if(i % 2 == 0)
    {
        sum += validationDigits[i];
    }
    else
    {
        sum += validationDigits[i] * 3;
    }
}

int result = (10 - (sum % 10)) % 10;

Console.WriteLine($"Suma: {sum}");
Console.WriteLine($"Cyfra kontrolna: {result}");