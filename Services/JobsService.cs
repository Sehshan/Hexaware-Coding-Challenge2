using careerHub.Repository;
using careerHub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Services
{
    internal class JobsService : IJobsService
    {
        private JobsRepository _jobRepository;

        public JobsService()
        {
            _jobRepository = new JobsRepository();
        }

        public void InsertJobListing(Jobs job)
        {
            if (job == null)
            {
                Console.WriteLine("Invalid job data provided.");
                return;
            }

            try
            {
                _jobRepository.InsertJobListing(job);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in service while adding job listing: " + ex.Message);
            }
        }
        public void GetAllJobListings()
        {
            try
            {
                List<Jobs> jobListings = _jobRepository.GetAllJobListings();

                if (jobListings.Any())
                {
                    Console.WriteLine("Job Listings:");
                    foreach (var job in jobListings)
                    {
                        Console.WriteLine($"Title: {job.JobTitle}");
                        Console.WriteLine($"Description: {job.JobDescription}");
                        Console.WriteLine($"Location: {job.JobLocation}");
                        Console.WriteLine($"Salary: {job.Salary}");
                        Console.WriteLine($"Job Type: {job.JobType}");
                        Console.WriteLine($"Posted Date: {job.PostedDate.ToString()}");
                    }
                }
                else
                {
                    Console.WriteLine("No job listings found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in service while retrieving job listings: " + ex.Message);
            }
        }
    }
}