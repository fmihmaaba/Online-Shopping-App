using System;

// Functions:
// First is asking the users name, phone number, address, and email. Second, you have to display the menu on the screen.
// Razer Viper Mini $39.99, Zygen NP-01 $89, Logitech G Pro X Superlight $129.95, Glorious Model O $61.89, Logitech G304 $41.24. 
// Then, the program will asks the user to Enter an item of their desired mouse. And the interface will show the mouse and the price.

namespace OnlineShoppingApp

{
09
    class Program
10
    {
11
        static void Main(string[] args)
12
        {
13
            string name;
14
            string PhoneNumber;
15
            string Address;
16
            string Email;
17
 
18
            //User inputs
19
            Console.WriteLine("Welcome to Rotocube Gaming Mouses <Press any key to continue>");
20
            Console.ReadKey();
21
            Console.Write("Enter your name: ");
22
            name = Console.ReadLine();
23
            Console.Write("Enter your PhoneNumber: ");
24
            PhoneNumber = Console.ReadLine();
25
            Console.Write("Enter your Address: ");
26
            Address = Console.ReadLine();
27
            Console.Write("Enter your E-mail: ");
28
            Email = Console.ReadLine();

    {
        static void Main(string[] args)
        {
        List<string> mouses = new List<string>() { Razer Viper Mini, ZygenNP - 01 };
        items.add(Logitech G Pro X SuperLight);
        items.add(Glorious Model O);
        items.add(Logitech G304);

        Console.WriteLine("What kind of Mouse do you want?");
        Console.WriteLine(mouses[Razer Viper Mini]);
        Console.WriteLine(mouses[ZygenNP - 01]);
        Console.WriteLine(mouses[Logitech G Pro X SuperLight]);
        Console.WriteLine(mouses[Glorious Model O]);
        Console.WriteLine(mouses[Logitech G304]);
        }
    }

29
 
30
            //Display the Mouses
31
            Console.WriteLine("\nGamingMouses Menu \nRazerViperMini $39.99 \nZygenNP-01 $89 \nLogitechGProXSuperLight $129.95 \nGloriousModelO $61.89 \nLogitechG304 $41.24");
32
            Console.ReadKey();

        int mouse;

    Console.WriteLine("Enter an item");

        mouse = Convert.ToInt32(Console.Readline()) ;
        switch (mouse) 

           {
  case 1:
    Console.WriteLine("Razer Viper Mini");
    break;
  case 2:
    Console.WriteLine("Zygen NP-01");
    break;
  case 3:
    Console.WriteLine("Logitech G Pro X SuperLight");
    break;
  case 4:
    Console.WriteLine("Glorious Model O");
    break;
  case 5:
    Console.WriteLine("Logitech G304");
    break;

 
        string message = "Are you sure about buying our product?";
    string title = "Close Window";
    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
    DialogResult result = MessageBox.Show(message, title, buttons);  
if (result == DialogResult.Yes) {  
    this.Close();  
} else {  
    // Do something  
}  

           } 
34
        }
35
    }
36
}
