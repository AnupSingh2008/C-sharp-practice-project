using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    abstract class Customer_TestAbstractCanHaveConstructor
    {
        private Guid _id;

       
        public Customer_TestAbstractCanHaveConstructor()
        {
            this._id = Guid.NewGuid();
        }

        public Guid ID
        {
            get { return this._id; }
        }

    }

    class SavingCustomer : Customer_TestAbstractCanHaveConstructor
    {
        public SavingCustomer()
        {

        }
    } 
    class CorporateCustomer : Customer_TestAbstractCanHaveConstructor
    {
        public CorporateCustomer()
        {

        }
    }
    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        SavingCustomer sc = new SavingCustomer();
    //        Console.WriteLine(sc.ID);

    //        CorporateCustomer cc = new CorporateCustomer();
    //        Console.WriteLine(cc.ID);

    //    }
    //}
}
