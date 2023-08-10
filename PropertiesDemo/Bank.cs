using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    // Public class
    public class Bank
    {
        // public data members
        public int bankId;       
        public string bankName;
        public string bankType;
        public string bankDescription;
        public string bankAddress;

        // private data members
        private decimal bankBalance=123030404;

        //Lets a define a property
        //syntax 
        // <access_modifier> <return_type> <Property name> {
        //
        // get {// body}}
        //set {// body }}

        public decimal BankBalance {

            //read only propertery 
            get {
                return bankBalance;
            }

            ////  Set only property
            set
            {

                bankBalance = value;
            }
        }

    }

    //Another public class
    public class Account
    {


    }
}
