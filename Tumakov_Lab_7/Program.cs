using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // УПР 7.1
            Console.WriteLine("УПР 7.1 Создать класс банковского счета");
            Bank_Akk_1 bank_1 = new Bank_Akk_1(1231, 400000, Type_Akk.SberKniga);
            Console.WriteLine("Ваш счет под номером:{0} \nСодержит сумму:{1} \nИ находится в {2}",bank_1.Id, bank_1.Balance, bank_1._Type);
            // 7.2
            Console.WriteLine("");
            Random random = new Random();
            Bank_Akk_2 bank_2 = new Bank_Akk_2(random.Next(100000), 4000000, Type_Akk.SberKniga);
            Bank_Akk_2 bank_3 = new Bank_Akk_2(random.Next(100000), 5000000, Type_Akk.SberKniga);
            Console.WriteLine("Ваш счет под номером:{0} \nСодержит сумму:{1} \nИ находится в {2}", bank_2.Id, bank_2.Balance, bank_2._Type);
            Console.WriteLine("Ваш счет под номером:{0} \nСодержит сумму:{1} \nИ находится в {2}", bank_3.Id, bank_3.Balance, bank_3._Type);
        }
    }
}
