

Console.WriteLine("Ender a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if (result != 0)   //ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("user number is even.");
}