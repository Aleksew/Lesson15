using System;

namespace HW15_Task1
{
    //Создайте программу, в которой просите пользователя ввести при регистрации логин и пароль.
    //При этом должны выполняться такие правила:
    //- Для логина можно использовать только цифры, латинские буквы в верхнем и нижнем регистре и нижнее подчеркивание.
    //- Для пароля можно использовать буквы верхнего и нижнего регистра только латинского алфавита, цифры, знаки препинания, символы _!@#$%^&*().
    //В случае ввода логина, не удовлетворяющего условию, – должно создаваться одно исключение и выводиться на экран соответствующее сообщение.
    //Если введен пароль, не соответствующий правилам – должно создаваться другое исключение и другое сообщение.Сообщение должно информировать о том, что именно введено не верно.
    //Создайте классы соответствующих пользовательских исключений.
    //Вызовите возникновение всех созданных исключений и отловите их.
    //Выведите на экран информацию из отловленных исключений.

    class Program
    {
        delegate bool UserInput(string str);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Введи логин");
                string login = Console.ReadLine();
                if (!SingIn.IsAllLatinsOrDigitsOrUnderscores(login))
                {
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Введи пароль");
                string password = Console.ReadLine();
                if (!SingIn.IsAllLatinsOrDigitsOrPermittedSimbol(password))
                {
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"Пользователь зарестрирован. Логин:{login} пароль {password}");
                break;
            }
            Console.ReadKey();
        }
    }

}
