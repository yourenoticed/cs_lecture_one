// Greeting a user
Console.Write("Enter your username: ");
string username = Console.ReadLine();
if (username.ToLower() == "noticed")
{
    Console.WriteLine("Whassup noticed!");
}
else
{
    Console.WriteLine("Hello, " + username.ToLower() + "!");
}