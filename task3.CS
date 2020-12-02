using System;  
public class Task3 
{  
    public static void Main() 
{
    int chk_year;
    Console.Write("\n\n");
    Console.Write("Check whether a given year is leap year or not:\n");
    Console.Write("----------------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input an year : ");
    chk_year= Convert.ToInt32(Console.ReadLine());
 
    if ((chk_year % 400) == 0)
 Console.WriteLine("{0} is a leap year.\n", chk_year);
    else if ((chk_year % 100) == 0)
 Console.WriteLine("{0} is not a leap year.\n", chk_year);
    else if ((chk_year % 4) == 0)
 Console.WriteLine("{0} is a leap year.\n", chk_year);
    else
 Console.WriteLine("{0} is not a leap year.\n", chk_year);
}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class Exercise3
    {
        static void Main(string[] args)
        {
    double rl,phy,che,ca,total;
    double per;
    string nm,div;

    Console.Write("\n\n");
    Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
    Console.Write("-------------------------------------------------------------------------------");
    Console.Write("\n\n");


    Console.Write("Input the Roll Number of the student :");
    rl = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the Name of the Student :");
    nm = Console.ReadLine();

    Console.Write("Input  the marks of Physics : ");
    phy= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of  Chemistry : ");
    che = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of Computer Application : ");
    ca = Convert.ToInt32(Console.ReadLine());

    total = phy+che+ca;
    per = total/3.0;
    if (per>=60)
	 div="First";
    else
	if (per<60&&per>=48)
	    div="Second";
	else
	    if (per<48&&per>=36)
		div="Pass";
	     else
		div="Fail";

       Console.Write("\nRoll No : {0}\nName of Student : {1}\n",rl,nm);
       Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n",phy,che,ca);
       Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,div);
}
}



using System;  
public class Exercise3 
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
