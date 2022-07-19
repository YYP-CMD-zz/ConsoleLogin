
Console.WriteLine("Choose your option: \n1 = Continue                2 = Cancel                3 = Help");
string option = Console.ReadLine();
if (option == "1")
{
    Console.Clear();
    Console.WriteLine("Welcome\nPlease enter your Username: ");
} else if (option == "2")
{
    Console.Clear();
    Console.WriteLine("You can close this Window now.");
}else if (option == "3")
{
    Console.Clear();
    Console.WriteLine("If you are having any Problems, you can contact the Developer at: https://t.me/YYP21");
}

string usrname = Console.ReadLine();
if (usrname == "root")
{
    
    Console.Clear();
    Console.WriteLine("Please Enter your Password:");
}else
{
    Console.WriteLine("Wrong Username please try again");
}

string pass = Console.ReadLine();
if (pass == "root")
{
    Console.Clear();
    Console.WriteLine("Login success");
}
else
{
    Console.Clear();
    Console.WriteLine("Wrong Password, please try again!");
}


Console.ReadLine();
