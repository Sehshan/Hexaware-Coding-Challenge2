using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Model
{
    internal class Jobs
    {
        private int jobID;
        private int companyID;
        private string jobTitle;
        private string jobDescription;
        private string jobLocation;
        private decimal salary;
        private string jobType;
        private DateTime postedDate;

        public Jobs() 
        {

        }

        public int JobID
        {
            get { return jobID; }
            set { jobID = value; }
        }

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string JobLocation
        {
            get { return jobLocation; }
            set { jobLocation = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }

        public DateTime PostedDate
        {
            get { return postedDate; }
            set { postedDate = value; }
        }

        public Jobs(int jobID, int companyID, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType, DateTime postedDate)
        {
            JobID = jobID;
            CompanyID = companyID;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            JobLocation = jobLocation;
            Salary = salary;
            JobType = jobType;
            PostedDate = postedDate;
        }
    }
}
