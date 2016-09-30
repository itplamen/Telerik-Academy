//1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics 
//     (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes 
//     (class GSM holding instances of the classes Battery and Display).

//2. Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). 
//   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

//3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

//4. Add a method in the GSM class for displaying all information about it. Try to override ToString().

//5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.

//6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

//7. Write a class GSMTest to test the GSM class:
//    -Create an array of few instances of the GSM class.
//    -Display the information about the GSMs in the array.
//    -Display the information about the static property IPhone4S.

//8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).

//9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.

//10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.

//11. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

//12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//    -Create an instance of the GSM class.
//    -Add few calls.
//    -Display the information about the calls.
//    -Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//    -Remove the longest call from the history and calculate the total price again.
//    -Finally clear the call history and print it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] array = new GSM[3];

            GSM firstGSM = new GSM("Galaxy S 4", "Samsung", 800.00, "Misho");
            array[0] = firstGSM;

            GSM secondGSM = new GSM("Xperia", "Sony", 700.01, "Ivan");
            array[1] = secondGSM;

            GSM thirdGSM = new GSM("Optimus", "LG", 500.21, "Daniel");
            array[2] = thirdGSM;

            //Print information about the GSMs in the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i].ToString();
            }

            //Print information about the static property IPhone4S
            GSM.IPhone4S.ToString();

            //CallHistory test
            GSM fourthGSM = new GSM("Desire 500", "HTC", 1111, "Maria");
            
            //Add calls and print
            Console.WriteLine("Add some calls and print...");
            fourthGSM.AddCalls(DateTime.Now, "088088311", 55);
            fourthGSM.AddCalls(DateTime.Now, "088088088", 94);
            fourthGSM.AddCalls(DateTime.Now, "088111221", 33);
            fourthGSM.PrintCalls();
          
            //Delete call and print
            Console.WriteLine("Delete call and print... ");
            fourthGSM.DeleteCalls(55);
            fourthGSM.PrintCalls();

            //Calculate total price
            fourthGSM.CalculateTotalPrice(0.37);

            //Clear calls and print
            fourthGSM.ClearCalls();
            fourthGSM.PrintCalls();
        }
    }
}
