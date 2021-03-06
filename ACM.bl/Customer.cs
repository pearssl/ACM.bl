﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class Customer
    {
        public Customer()
        {

        } 
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }

        ///<summary>
        /// Validates the customer code
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;

        }
        ///<summary>
        ///Retrieve one customer
        ///</summary>
        public Customer Retrieve(int customerId)
        {
            //Code that retrieves the defined customer
            return new Customer();

        }

        ///<summary>
        ///Retrieve all customers
        ///</summary>
        public List<Customer> Retrieve()
        {
            //Code that retrieves the defined customer
            return new List<Customer>();

        }
        ///<summary>
        ///Saves the current customer
        ///</summary>
        public bool Save()
        {
            //COde that saves the defined customer
            return true;
        }
    }
}
