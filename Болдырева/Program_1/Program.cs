// 01_01.cs - первая программа
using static System.Console;
class HelloUser

{
   static void Main()
   {
       string name;
       WriteLine("Введите ваше имяя: ");
       name = ReadLine();
       WriteLine("Приветствую Васс, " + name + "!");
        WriteLine(" /infl Завершение сеанса нажмите ENTER. ");
        ReadLine();
   }
}
