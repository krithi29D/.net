using System;
public class Age
{
public int Years;
public int Months;
public int Days;
public Age(DateTime Bday)
{
this.Count(Bday);
}
public Age(DateTime Bday, DateTime Cday)
{
this.Count(Bday, Cday);
}
public Age Count(DateTime Bday)
{
return this.Count(Bday, DateTime.Today);
}
public Age Count(DateTime Bday, DateTime Cday)
{
if ((Cday.Year - Bday.Year) > 0 ||
(((Cday.Year - Bday.Year) == 0) && ((Bday.Month < Cday.Month) ||
((Bday.Month == Cday.Month) && (Bday.Day <= Cday.Day)))))
{
int DaysInBdayMonth = DateTime.DaysInMonth(Bday.Year, Bday.Month);
int DaysRemain = Cday.Day + (DaysInBdayMonth - Bday.Day);
if (Cday.Month > Bday.Month)
{
this.Years = Cday.Year - Bday.Year;
this.Months = Cday.Month - (Bday.Month + 1) + Math.Abs(DaysRemain / DaysInBdayMonth);
this.Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
}
else if (Cday.Month == Bday.Month)
{
if (Cday.Day >= Bday.Day)
{
this.Years = Cday.Year - Bday.Year;
this.Months = 0;
this.Days = Cday.Day - Bday.Day;
}
else
{
this.Years = (Cday.Year - 1) - Bday.Year;
this.Months = 11;
this.Days = DateTime.DaysInMonth(Bday.Year, Bday.Month) - (Bday.Day - Cday.Day);
}
}
else
{
this.Years = (Cday.Year - 1) - Bday.Year;
this.Months = Cday.Month + (11 - Bday.Month) + Math.Abs(DaysRemain / DaysInBdayMonth);
this.Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
}
}
else
{
throw new ArgumentException("Birthday date must be earlier than current date");
}
return this;
}
}




using System;  
public class Exercise22  
{  
    public static void Main()
{
   int monno;


           Console.Write("\n\n");
           Console.Write("Read month number and display month name:\n");
           Console.Write("-------------------------------------------");
           Console.Write("\n\n");


         Console.Write("Input Month No : ");
         monno = Convert.ToInt32(Console.ReadLine());

   switch(monno)
   {
	case 1:
	       Console.Write("January\n");
	       break;
	case 2:
	       Console.Write("February\n");
	       break;
	case 3:
	       Console.Write("March\n");
	       break;
	case 4:
	       Console.Write("April\n");
	       break;
	case 5:
	       Console.Write("May\n");
	       break;
	case 6:
	       Console.Write("June\n");
	       break;
	case 7:
	       Console.Write("July\n");
	       break;
	case 8:
	       Console.Write("August\n");
	       break;
	case 9:
	       Console.Write("September\n");
	       break;
	case 10:
	       Console.Write("October\n");
	       break;
	case 11:
	       Console.Write("November\n");
	       break;
	case 12:
	       Console.Write("December\n");
	       break;
	default:
	       Console.Write("invalid Month number. \nPlease try again ....\n");
	       break;
      }
   }
}




