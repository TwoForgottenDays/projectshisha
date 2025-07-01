for (int i = 1; i >= 0; i++) 
{
    
    if ( i % 3 == 0) 
    {
        Console.WriteLine("Es robsito: " + i);
        continue; // Skip the rest of the loop for even numbers
    }
    {
        if (i % 5 != 0)
        {
            Console.WriteLine("Es calvo: " + i);
        }
        if (i % 7 == 0)
        {
            Console.WriteLine("Es calvo y robosito: " + i);
            Console.WriteLine("Es calvo y robosito: " + -i);
        }

        if (i == 100)

                break;
    }
}
