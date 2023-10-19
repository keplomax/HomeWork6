using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_7
{
    internal class Bank_Akk_2
    {
        private int id;
        private static int id_uniq;
        private int balance;
        private Type_Akk _type;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public Type_Akk _Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        private void Increase_id()
        {
            id_uniq++;  
        }
        public Bank_Akk_2(int id, int balance, Type_Akk _type)
        {
            id_uniq = id;
            this.balance = balance;
            this._type = _type;
            Increase_id();
        }
    }
}
