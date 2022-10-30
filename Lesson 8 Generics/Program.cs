using Lesson_8_Generics;

Console.WriteLine("Enter password.");
string password = Console.ReadLine();

Console.WriteLine("Enter Id");
int id = Convert.ToInt16(Console.ReadLine());

Pair<int, string> User = new Pair<int, string>(password, id);
Console.WriteLine(User.Password);
Console.WriteLine(User.Id);

