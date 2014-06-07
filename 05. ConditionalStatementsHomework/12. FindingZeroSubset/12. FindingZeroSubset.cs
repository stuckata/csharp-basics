using System;

class FindingZeroSubset
{
    static void Main()
    {
        Console.WriteLine("enter 5 integer numbers: ");
        Console.Write("a = ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int numB = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int numC = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int numD = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int numE = int.Parse(Console.ReadLine());
        int check = 0;

        if (numA + numB == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numA, numB);
            check++;
        }
        if (numA + numB + numC == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numA, numB, numC);
            check++;
        }
        if (numA + numB + numC + numD == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numB, numC, numD);
            check++;
        }
        if (numA + numB + numC + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numA, numB, numC, numD, numE);
            check++;
        }
        if (numA + numC == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numA, numC);
            check++;
        }
        if (numA + numC + numD == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numA, numC, numD);
            check++;
        }
        if (numA + numC + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numC, numD, numE);
            check++;
        }
        if (numA + numD == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numA, numD);
            check++;
        }
        if (numA + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numA, numD, numE);
            check++;
        }
        if (numA + numE == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numA, numE);
            check++;
        }
        if (numB + numC == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numB, numC);
            check++;
        }
        if (numB + numC + numD == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numB, numC, numD);
            check++;
        }
        if (numB + numC + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numB, numC, numD, numE);
            check++;
        }
        if (numB + numD == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numB, numD);
            check++;
        }
        if (numB + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numB, numD, numE);
            check++;
        }
        if (numB + numE == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numB, numE);
            check++;
        }
        if (numC + numD == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numC, numD);
            check++;
        }
        if (numC + numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", numC, numD, numE);
            check++;
        }
        if (numC + numE == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numC, numE);
            check++;
        }
        if (numD + numE == 0)
        {
            Console.WriteLine("{0} + {1} = 0", numD + numE);
            check++;
        }
        if (check == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

