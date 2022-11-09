Console.WriteLine("Goodbye World!!!"); //1 Задание 

Console.Write("Hello" + " " + "World!!!\n"); //2 Задание 

Console.Write("Hello" + " " + "World!!! \nBye!\n"); //2 Задание под звёздочкой (надеюсь правильно понял смысл задания)

string fullName = "";
int old = 18;
string number = "+7 (914) 123-123-21";
string email = "test@joy.ty";
int resultMath = 72;
Console.WriteLine($"ФИО участника: {fullName}\nВозраст: {old}\nНомер телефона: {number}\nАдрес электронной почты: {email}\nРезультаты ЕГЭ по математика(профиль): {resultMath}");

Console.WriteLine("Укажите любое целое число, которое будет являться максимальным числов в игре (число должно привышать 0) ");
string userNumber = Console.ReadLine();
int userNumber1 = Int32.Parse(userNumber);
while(userNumber1 <= 0)
{
    Console.WriteLine("Введите число привышающее 0");
    userNumber = Console.ReadLine();
    userNumber1 = Int32.Parse(userNumber);
}
Console.WriteLine($"И так, вы загадали число {userNumber}. Это число будет являться максимально допустимым диапозоном в этой игре, минимальным же числом является 0. Суть игры: вам предстоит угадать случайно загаданное число на промежутке от 0 до {userNumber}. В случае неудачи программа сообщит о том, загаданное число больше или меньше. В случае правильного ответа - игра завершится. Если играть надоело, то вместо ввода числа отставьте пустое поле и нажмите enter. Удачи!");
Random rnd = new Random();
int value = rnd.Next(0, userNumber1);
int option = Int32.Parse(Console.ReadLine());
while (option != value)
{
    if (option > value)
    {
        Console.WriteLine("Ваш вариант больше, чем загаданное число");
    }
    else
    {
        Console.WriteLine("Ваш вариант меньше, чем загаданное число");
    }
        option = Int32.Parse(Console.ReadLine());
}
if (option == value)
{
    Console.WriteLine("Поздравляю, вы победили!");
}
//У меня не вышло реализовать выход из игры(((
