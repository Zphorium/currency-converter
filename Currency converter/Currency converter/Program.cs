

Console.WriteLine("Welcome to Zphorium's Currency Chenter");
Console.WriteLine("If u want to see our command's pls use /help");


string helpCommand = Console.ReadLine();

if (helpCommand == "/help")
{
    Console.WriteLine("###########################");
    Console.WriteLine("/show-recent-currency-rates");
    Console.WriteLine("/find-currency-rate-by-code ");
    Console.WriteLine("/calculate-amount-by-currecy");
    Console.WriteLine("/stop");
    Console.WriteLine("###########################");
}

string mainCurrency = "AZN";
string[] currency = {"USD", "TRY", "RUB", "EUR"};
double[] valuecurrency = { 1.7, 0.1031, 0.0271, 1.8271};

int currencyIndex = 0;
int currencyInterval = currency.Length - 1;
 
int valueIndex = 0;
int valueInterval = valuecurrency.Length - 1;

string secondStage = Console.ReadLine();


while (true)
{ 
    if(secondStage == "/stop")
    {
        Console.WriteLine("BYEE");
        break; 
    }
     
    while (secondStage == "/show-recent-currency-rates")
    {
        while (currencyIndex < currency.Length && valueIndex < valuecurrency.Length)
        {
            Console.WriteLine(currency[currencyIndex] + " :" + valuecurrency[valueIndex]);
            currencyIndex++;
            valueIndex++;
            
        }
        continue;
    }

    while (secondStage == "/find-currency-rate-by-code")
    {
        Console.WriteLine("Select your currency :");
        string alpha3 = Console.ReadLine();

        if (alpha3 == "USD")
        {
            Console.WriteLine("USD---1.7 AZN"+ " " + mainCurrency);
        }
        if (alpha3 == "TRY")
        {
            Console.WriteLine("TRY---0.1031 AZN" + " " + mainCurrency);
        }
        if (alpha3 == "RUB")
        {
            Console.WriteLine("RUB---0.0271 AZN"+ " " + mainCurrency);
        }
        if (alpha3 == "EUR")
        {
            Console.WriteLine("EUR---1.8271" + " " + mainCurrency);

        }
    }

    while (secondStage == "/calculate-amount-by-currecy")
    {
        float myCash;
        float totalCash;
        Console.WriteLine("Enter your cash : ");
        myCash = Convert.ToInt32(Console.ReadLine());
        
        if (myCash <= 0 || myCash >= 10000)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("The amount of your money should not exceed 1-10000");
            Console.WriteLine("**************************************************");
        }

        if (myCash >= 1 && myCash <= 10000)
        {
            Console.WriteLine("Select the currency you want to convert :");
            string alpha3 = Console.ReadLine();


            if (alpha3 == "USD")
            {
                totalCash = (float)(myCash * 1.7);

                Console.WriteLine(totalCash + " " + mainCurrency );
            }
            if (alpha3 == "TRY")
            {
                totalCash = (float)(myCash * 0.1031);
                Console.WriteLine(totalCash + " " + mainCurrency);
            }
            if (alpha3 == "RUB")
            {
                totalCash = (float)(myCash * 0.0271);
                Console.WriteLine(totalCash + " " + mainCurrency);
            }
            if (alpha3 == "EUR")
            {
                totalCash = (float)(myCash * 1.8271 );
                Console.WriteLine(totalCash + " "  + mainCurrency);
            }
          
        }
      
    } 
    
}

