using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    //класс для работы с паролями
    public class Auth
    {
        //создаем публичный метод 
        public string TestPassword(string password)
        {
            //Проверяем пароль на длину строки от 7 до 10 включительно
            if (password.Length >= 7 && password.Length <= 10)
            {
                //переменная для проверки цифры
                bool IsDigit = false;
                //переменная для проверки верхнего регистра
                bool IsUpper = false;
                //переменная для проверки нижнего регистра
                bool IsLower = false;
                //переменная для проверки спецсимволов
                bool IsSpec = false;
                //цикл по всем символам пароля
                foreach (var item in password)
                {
                    //проверяем пароль на цифры
                    if (char.IsDigit(item))
                    {
                        IsDigit = true;
                    }
                    //проверяем пароль на буквы верхнего регистра
                    if (char.IsUpper(item))
                    {
                        IsUpper = true;
                    }
                    //проверяем пароль на буквы нижнего регистра
                    if (char.IsLower(item))
                    {
                        IsLower = true;
                    }
                    //проверяем пароль на спецсимволы
                    if ("@#$%^&".Contains(item))
                    {
                        IsSpec = true;
                    }
                }
                //Проверяем переменную если истина то цифры есть
                if (!IsDigit)
                {
                    return "Пароль должен содержать цифры!";
                }
                //Проверяем переменную если истина то есть буквы нижнего регистра
                if (!IsLower)
                {
                    return "Пароль должен содержать симнволы в нижнем регистре!";
                }
                //Проверяем переменную если истина то есть буквы верхнего регистра
                if (!IsUpper)
                {
                    return "Пароль должен содержать символы в верхнем регистре!";
                }
                //Проверяем переменную если истина то есть спецсимволы
                if (!IsSpec)
                {
                    return "Пароль должен содержать спецсимволы!";
                }
                //возвращает (выходит) из метода с сообщением в квадратных ковычках
                return "Пароль отличный!";
            }
            //если длина пароля меньше 7 или больше 10 то вернем сообщение об ошибке
            else
            {
                return "Неверная длина пароля!";
            }
        }
    }
}
