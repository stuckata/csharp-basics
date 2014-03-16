using System;

class CalculateGravitationOnTheMoon
{
    static void Main()
    {
        double weightOnEarth = 74.6;
        double weightOnMoon = (0.17 * weightOnEarth); //the gravitational field of the Moon is approximately 17% of that on the Earth
        Console.WriteLine("The weight on the Earth is {0}, on the Moon this will refer to weight of {1}"
            , weightOnEarth, weightOnMoon);
    }
}

