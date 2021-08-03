using System;

namespace HW15_Task1
{
    public static class SingIn
    {
        public static bool IsAllLatinsOrDigitsOrUnderscores(string s)
        {
            try
            {
                if (s.Length < 3)
                {
                    throw new LoginException("Логин должен быть длинее 3 символов");
                }

                foreach (char c in s)
                {
                    if (!IsLatin(c) && !char.IsDigit(c) && c != '_')

                        throw new LoginException($"Логин содержит недопустимый символ - {c}");
                }
                return true;
            }
            catch (LoginException)
            {
                return false;
            }
        }
        public static bool IsAllLatinsOrDigitsOrPermittedSimbol(string s)
        {
            try
            {
                if (s.Length < 3)
                {
                    throw new PasswordException("Пароль должен быть длинее 3 символов");
                }

                foreach (char c in s)
                {

                    if (!IsLatin(c) && !char.IsDigit(c) && !IsPermittedSimbol(c))

                        throw new PasswordException($"Пароль содержит недопустимый символ - {c}");
                }
                return true;
            }
            catch (PasswordException)
            {
                return false;
            }
        }

        public static bool IsLatin(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public static bool IsPermittedSimbol(char c)
        {
            switch (c)
            {
                case '_':
                case '!':
                case '@':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }

        class LoginException : Exception
        {
            public LoginException(string message) : base(message)
            {
                Console.WriteLine(message);
            }
        }

        class PasswordException : Exception
        {
            public PasswordException(string message) : base(message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
