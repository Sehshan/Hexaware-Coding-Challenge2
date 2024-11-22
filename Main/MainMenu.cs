using careerHub.Repository;
using careerHub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using careerHub.Model;

namespace careerHub.Main
{
    internal class MainMenu
    {
        public static void careerHub()
        {

            JobsService jobService = new JobsService();

            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Add Job Listing");
                Console.WriteLine("2. View All Job Listings");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter CompanyId: ");
                        int companyId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Job Title: ");
                        string jobTitle = Console.ReadLine();

                        Console.Write("Enter Job Description: ");
                        string jobDescription = Console.ReadLine();

                        Console.Write("Enter Job Location: ");
                        string jobLocation = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter Job Type (e.g., Full-time): ");
                        string jobType = Console.ReadLine();

                        Console.Write("Enter Posted Date (yyyy-mm-dd): ");
                        DateTime postedDate = Convert.ToDateTime(Console.ReadLine());

                        Jobs job = new Jobs
                        {
                            JobTitle = jobTitle,
                            JobDescription = jobDescription,
                            JobLocation = jobLocation,
                            Salary = salary,
                            JobType = jobType,
                            PostedDate = postedDate
                        };
                        jobService.InsertJobListing(job);
                        break;
                    case "2":
                        jobService.GetAllJobListings();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}