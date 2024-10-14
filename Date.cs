// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace hw1
// {
   
//          public class Date(int day, int month, int year, string DayOFWeek)
//     {
        


//     public int Day{
//         get{
//             return day;
//         }
//         set{
//             if(value > 0 && value <= 31){
//                 day = value;
//             }
//         }
//     }


//      public string Day_Of_Week{
//         get{
//             return DayOFWeek;
//         }
//         set{
//             if(value != null){
//                 DayOFWeek = value;
//             }
//         }
//     }



//     public int Month{
//         get{
//             return month;
//         }

//         set{
//             if(value > 0 && value <= 12){
//                 month = value;
//             }
//         }
//     }


//     public int Year{
//         get{
//             return year;
//         }

//         set { 
//             if(value > 0){
//             year = value;
//             }
//              }
//     }

// public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) {}
// public Date(int day, int month, int year){
// this.Year = year;
// this.Month = month;
// this.Day = day;
// }






    
    
// }
// }









using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace hw1
{
   
         public class Date
    {
        
private int day;
private int month;
private int year;

string DayOFWeek;

    public int Day{
        get{
            return day;
        }
        set{
            if(value > 0 && value <= 31){
                day = value;
            }
        }
    }


     public string Day_Of_Week{
        get{
            return DayOFWeek;
        }
        set{
            if(value != null){
                DayOFWeek = value;
            }
        }
    }



    public int Month{
        get{
            return month;
        }

        set{
            if(value > 0 && value <= 12){
                month = value;
            }
        }
    }


    public int Year{
        get{
            return year;
        }

        set { 
            if(value > 0){
            year = value;
            }
             }
    }

public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) {}
public Date(int day, int month, int year){
Year = year;
Month = month;
Day = day;
}



 public void DateDiff(){
         // Ввод даты от пользователя
    Console.WriteLine("Enter a day: ");
    int day1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a month: ");
    int month1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a year: ");
    int year1 = int.Parse(Console.ReadLine());

    // Ввод второй даты
    Console.WriteLine("Enter the second date:");
    Console.WriteLine("Enter a day: ");
    int day2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a month: ");
    int month2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a year: ");
    int year2 = int.Parse(Console.ReadLine());

    // Создаем объекты DateTime
    DateTime firstDate = new DateTime(year1, month1, day1);
    DateTime secondDate = new DateTime(year2, month2, day2);

    // Вычисляем разницу в днях
    TimeSpan difference = secondDate - firstDate;
    int result = Math.Abs(difference.Days); // Абсолютное значение разницы в днях

    // Вывод результата
    Console.WriteLine($"Difference in days: {result}");
        
    }



public void changeDate(){
    Console.WriteLine("enter a value of days");
    string answer = Console.ReadLine();
    int days = int.Parse(answer);

this.Day += days;
int past = days;

for(int i = 0; i > past; i++){
    past--;

    if(this.Day > 31){
        this.Day = 1;
        this.Month += 1;

        if(this.Month > 12){
            this.Month = 1;
        }
    }
}
    
    Console.Write("new date: " + this.Day + "." + this.Month + "." + this.Year + "\n");

}


public void print(){
Console.Write("date: " + this.Day + "." + this.Month + "." + this.Year + "\n");
}


    
    
}
}