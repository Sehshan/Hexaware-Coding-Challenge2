﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Model
{
    internal class Company
    {
        private int companyID;          
        private string companyName;     
        private string location;   
        
        public Company()
        {

        }

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Company(int companyID, string companyName, string location)
        {
            CompanyID = companyID;
            CompanyName = companyName;
            Location = location;
        }   
    }
}