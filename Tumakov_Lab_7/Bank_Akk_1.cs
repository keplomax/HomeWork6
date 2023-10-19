using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_7
{
    public enum Type_Akk
    {
        Balance,
        SberKniga
    }
    internal class Bank_Akk_1
    {
        private int id;
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
        public Bank_Akk_1(int id, int balance, Type_Akk _type) 
        {
            this.id = id;
            this.balance = balance;
            this._type = _type;
        }

    }
}
