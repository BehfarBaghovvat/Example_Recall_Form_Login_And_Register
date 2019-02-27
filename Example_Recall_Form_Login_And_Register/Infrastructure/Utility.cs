using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Recall_Form_Login_And_Register.Infrastructure
{
    public static class Utility
    {
        static Utility()
        {

        }


        /// <summary>
        /// myLoginForm field.
        /// </summary>
        private static LoginForm myLoginForm;
            
        
        public static LoginForm MyLoginForm
        {
            get
            {
                if (myLoginForm==null)
                {
                   myLoginForm= new LoginForm();
                }

                return myLoginForm;
            }
        }


        /// <summary>
        /// myRegisterForm field.
        /// </summary>

        private static RegisterForm myRegisterForm;

        public static RegisterForm MyRegisterForm
        {
            get
            {
                if (myLoginForm==null)
                {
                    myLoginForm = new LoginForm();
                }

                return myRegisterForm;
            }
            
        }




    }
}
