using System;

class TemperaturesComparison
{
    static void Main()
    {
        double[] temperatures = new double[5];
        double totalTemperature = 0;
        int validTemperatures = 0;

        // Input 5 temperatures, must be btw (-30 to 130)
        while (validTemperatures < 5)
        {
            // Input temperature from user
            Console.Write("Input Temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            // Validate temperature range using if-else
            if (temp >= -30 && temp <= 130)
            {
                // Store the valid temperature
                temperatures[validTemperatures] = temp;
                totalTemperature += temp;
                validTemperatures++; // Move to the next valid temperature
            }
            else
            {
                // Output error message if temperature is out of range
                Console.WriteLine($"Temperature {temp} is invalid, Please enter a valid temperature between -30 and 130");
            }
        }

        // Check the trend of temperatures
        bool isGettingWarmer = true;
        bool isGettingColder = true;

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
                isGettingWarmer = false;

            if (temperatures[i] >= temperatures[i - 1])
                isGettingColder = false;
        }

        // Display the appropriate message based on temperature trend
        if (isGettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isGettingColder)
        {
            Console.WriteLine("Getting colder");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        // Display the entered temperatures
        Console.Write("5-day Temperature: [");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write(temperatures[i]);
            if (i < temperatures.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        // Calculate and display the average temperature
        double averageTemperature = totalTemperature / temperatures.Length;
        Console.WriteLine($"Average Temperature is {averageTemperature:N1} degrees");
    }
}
