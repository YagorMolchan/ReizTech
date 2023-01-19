using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Exceptions;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 0, minute = 0;
            
            try
            {
                Console.WriteLine("Hours: ");

                hour = int.Parse(Console.ReadLine());

                Console.WriteLine("Minutes: ");

                minute = int.Parse(Console.ReadLine());                               

                float dMinute = minute.GetMinuteInDegrees();

                float dHour = hour.GetHourInDegrees();

                float fDegree = dHour - dMinute;

                if (fDegree >= 180 && fDegree <= 360)
                {
                    fDegree = 360 - fDegree;
                }

                Console.WriteLine("Time: " + hour + ":" + minute);

                Console.WriteLine("Degrees: " + fDegree);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("The hour and the minute must be numeric!!!");
            }
            catch(HourException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MinuteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            


        }
    }
}
