using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3_3
{
    internal class Class3 : Class2
    {
        public override void ConvertToBinary(string validatedMobileNo)
        {
   
        }

        public override string ValidateMobile(string mobileNo)
        {
            string newMobileNo = "";
            if (mobileNo.Length == 11 && mobileNo[0] == '0') 
            {
                newMobileNo = mobileNo;

            } else if(mobileNo.Length == 13 && mobileNo.StartsWith("+98"))
            {
                newMobileNo = mobileNo.Substring(3);
                newMobileNo = string.Format("0{0}", newMobileNo);

            } else
            {
                newMobileNo = "0";
            }

            return newMobileNo;
        }
    }
}
