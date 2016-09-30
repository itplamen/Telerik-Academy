//05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

    class ConvertHexadecimalNumberToBinary
    {
        static void ConvertToBinry(string hexadecimalNumber)
        {
            string binaryNumber = "";
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                switch (hexadecimalNumber[i])
                {
                    case '0':
                        binaryNumber = binaryNumber + " " + "0000";
                        break;
                    case '1':
                        binaryNumber = binaryNumber + " " + "0001";
                        break;
                    case '2':
                        binaryNumber = binaryNumber + " " + "0010";
                        break;
                    case '3':
                        binaryNumber = binaryNumber + " " + "0011";
                        break;
                    case '4':
                        binaryNumber = binaryNumber + " " + "0100";
                        break;
                    case '5':
                        binaryNumber = binaryNumber + " " + "0101";
                        break;
                    case '6':
                        binaryNumber = binaryNumber + " " + "0110";
                        break;
                    case '7':
                        binaryNumber = binaryNumber + " " + "0111";
                        break;
                    case '8':
                        binaryNumber = binaryNumber + " " + "1000";
                        break;
                    case '9':
                        binaryNumber = binaryNumber + " " + "1001";
                        break;
                    case 'A':
                        binaryNumber = binaryNumber + " " + "1010";
                        break;
                    case 'B':
                        binaryNumber = binaryNumber + " " + "1011";
                        break;
                    case 'C':
                        binaryNumber = binaryNumber + " " + "1100";
                        break;
                    case 'D':
                        binaryNumber = binaryNumber + " " + "1101";
                        break;
                    case 'E':
                        binaryNumber = binaryNumber + " " + "1110";
                        break;
                    case 'F':
                        binaryNumber = binaryNumber + " " + "1111";
                        break;
                    default:
                        Console.WriteLine("ERROR. Try again...\n");
                        Main();
                        break;
                } 
            }
            Console.WriteLine(binaryNumber);
        }

        static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine().ToUpper();

            ConvertToBinry(hexadecimalNumber);
        }
    }

