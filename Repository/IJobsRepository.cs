using careerHub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Repository
{
    internal interface IJobsRepository
    {
        void InsertJobListing(Jobs job);
        List<Jobs> GetAllJobListings();
    }
}
