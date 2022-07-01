using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week12_2
{
    class PHONELIST
    {
        private string HOMEPHONE, CELLPHONE, OFFICEPHONE;
        public void PHONE(string phone1, string phone2, string phone3)
        {
            HOMEPHONE = phone1;
            OFFICEPHONE = phone2;
            CELLPHONE = phone3;
        }
        public string printPHONE()
        {
            return $"住家電話:{HOMEPHONE}，公司電話:{OFFICEPHONE}，手機:{CELLPHONE}";
        }
    }
}
