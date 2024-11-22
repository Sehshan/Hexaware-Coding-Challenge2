using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Model
{
    internal class JobApplications
    {
        private int applicationID;
        private int jobID;
        private int applicantID;
        private DateTime applicationDate;
        private string coverLetter;
        
        public JobApplications() 
        {

        }

        public int ApplicationID
        {
            get { return applicationID; }
            set { applicationID = value; }
        }

        public int JobID
        {
            get { return jobID; }
            set { jobID = value; }
        }

        public int ApplicantID
        {
            get { return applicantID; }
            set { applicantID = value; }
        }

        public DateTime ApplicationDate
        {
            get { return applicationDate; }
            set { applicationDate = value; }
        }

        public string CoverLetter
        {
            get { return coverLetter; }
            set { coverLetter = value; }
        }

        public JobApplications(int applicationID, int jobID, int applicantID, DateTime applicationDate, string coverLetter)
        {
            ApplicationID = applicationID;
            JobID = jobID;
            ApplicantID = applicantID;
            ApplicationDate = applicationDate;
            CoverLetter = coverLetter;
        }

    }
}

