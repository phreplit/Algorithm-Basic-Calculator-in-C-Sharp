
// Author: PHNO - Tecnólogo | Pós-Graduado
// Release Date: 17/09/2023
// Version: 2.0.1v
// Replit: @PHNO, @PHREPLIT
// E-mail: phreplit@gmail.com

// Algorithm: Basic Calculator in C Sharp, with 4 basic operations, with menu and console compilation.

using System; // import lib

class Calculator { // class
  
 public static void Main (string[] args) {

   while (true) {
    // class, method, string
     Console.WriteLine ("\n"); 
     Console.WriteLine (" ::::::::::::::::::::::::::::::::::::::::::::::::::::::");
     Console.WriteLine (" :: Basic Calculator in C Sharp - 4 Basic Operations ::");
     Console.WriteLine (" ::::::::::::::::::::::::::::::::::::::::::::::::::::::");
     Console.WriteLine ("");
     Console.WriteLine ("  Menu \n");
     
     Console.WriteLine (" 1 - Sum"); 
     Console.WriteLine (" 2 - Subtract"); 
     Console.WriteLine (" 3 - Multiply"); 
     Console.WriteLine (" 4 - Divide"); 
     Console.WriteLine (" 5 - Exit"); 

     Console.WriteLine ("\n [9] About "); 

     Console.WriteLine ("\n Select one choice 1 to 5: "); 
     
      try {
      int choice = Convert.ToInt32 (Console.ReadLine ());
     Console.WriteLine("\n");
        
      switch (choice) {
	case 1:
      Console.WriteLine (" Enter first number: ");
	  int a = Convert.ToInt32 (Console.ReadLine ());
	  Console.WriteLine();
	  Console.WriteLine (" Enter second number: ");
	  int b = Convert.ToInt32 (Console.ReadLine ());
	  int sum = (a + b);
      Console.WriteLine();
      Console.WriteLine (" Sum result: " + (sum));
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	    break;
	  case 2:
      Console.WriteLine (" Enter first number: ");
	  int c = Convert.ToInt32 (Console.ReadLine ());
	  Console.WriteLine();
	  Console.WriteLine (" Enter second number: ");
	  int d = Convert.ToInt32 (Console.ReadLine ());
	  int sub = (c - d);
      Console.WriteLine();
	  Console.WriteLine (" Subtract result: " + (sub));
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	    break;
	  case 3:
      Console.WriteLine (" Enter first number: ");
	  int e = Convert.ToInt32 (Console.ReadLine ());
	  Console.WriteLine();
	  Console.WriteLine (" Enter second number: ");
	  int f = Convert.ToInt32 (Console.ReadLine ());
	  int mult = (e * f);
      Console.WriteLine();
	  Console.WriteLine (" Multiply result: " + (mult));
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	    break;
	  case 4:
      Console.WriteLine (" Enter first number: ");
	  int g = Convert.ToInt32 (Console.ReadLine ());
	  Console.WriteLine();
	  Console.WriteLine (" Enter second number: ");
	  int h = Convert.ToInt32 (Console.ReadLine ());
	  int div = (g / h);
      Console.WriteLine();
	  Console.WriteLine (" Divide result: " + (div));
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	    break;
	  case 5:
      Exit(); // call method
	    break;
	  case 9:
	  Clear();
      Console.WriteLine();
      Console.WriteLine(" Algorithm: Basic Calculator in C Sharp");
      Console.WriteLine("\n Author: PHNO");
      Console.WriteLine(" Release Date: 17/09/2023");
      Console.WriteLine(" Version: 2.0.1v");
      Console.WriteLine(" Replit: @PHNO, @PHREPLIT");
      Console.WriteLine(" E-mail: phreplit@gmail.com");
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	    break;
	  default:
      Console.WriteLine (" Error. choice other option. ");
      Console.WriteLine();
      Console.WriteLine(" Press enter to menu return...");
      Console.ReadKey();
      Clear(); // call method
	  break;
     }
     } catch (Exception e) {
       Console.WriteLine(" Error. system failure.");
       Console.WriteLine();
       Console.WriteLine(" Press enter to menu return...");
       Console.ReadKey();
       Clear(); // call method
     }  
    }
   }
	
   public static void Exit() { 
      Console.WriteLine();
      Console.WriteLine (" Finished Algorithm! ");
      System.Environment.Exit(-1);
      return;
     }
	
   public static void Clear() { 
     Console.Clear();
     return;
    }
  }
  
