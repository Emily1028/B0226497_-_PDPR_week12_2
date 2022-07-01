using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week12_2
{
    class CARD
    {
        private string NAME;
        private string EMAIL;
        PHONELIST PHONE=new PHONELIST();
        private int AGE;
        public CARD(string name, string email, string home, string cell, string office, int age)
        {
            NAME = name;
            EMAIL = email;
            AGE = age;
            PHONE.PHONE(home, cell, office);

        }
        public string getCARD()
        {
            return $"\n姓名:{NAME}，年齡:{AGE}，{PHONE.printPHONE()}，電子郵件:{EMAIL}";
        }

    }
}
