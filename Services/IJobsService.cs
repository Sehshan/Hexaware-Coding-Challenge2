using careerHub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Services
{
    internal interface IJobsService
    {
        void InsertJobListing(Jobs job);
        public void GetAllJobListings();
    }
}
