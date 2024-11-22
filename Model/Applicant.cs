using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Model
{
    internal class Applicant
    {
        private int applicantID;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string resume;
        public Applicant() 
        { 

        }

        public int ApplicantID
        {
            get { return applicantID; }
            set { applicantID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public Applicant(int applicantID, string firstName, string lastName, string email, string phone, string resume)
        {
            ApplicantID = applicantID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Resume = resume;
        }
    }
}
