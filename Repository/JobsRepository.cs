using careerHub.Model;
using careerHub.Repository;
using careerHub.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace careerHub.Repository
{
    internal class JobsRepository : IJobsRepository
    {
        private string _connectionString;

        public JobsRepository()
        {
            _connectionString = DbConnUtil.GetConnectionString();
        }

        public void InsertJobListing(Jobs job)
        {
            if (job == null)
            {
                Console.WriteLine("Invalid job data provided.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = @"INSERT INTO Jobs (CompanyId, JobTitle, JobDescription, JobLocation, Salary, JobType, PostedDate)
                             VALUES (@CompanyId, @JobTitle, @JobDescription, @JobLocation, @Salary, @JobType, @PostedDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyId", job.CompanyID);
                        command.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                        command.Parameters.AddWithValue("@JobDescription", job.JobDescription);
                        command.Parameters.AddWithValue("@JobLocation", job.JobLocation);
                        command.Parameters.AddWithValue("@Salary", job.Salary);
                        command.Parameters.AddWithValue("@JobType", job.JobType);
                        command.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Job listing added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add the job listing.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while adding job listing: " + ex.Message);
                }
            }
        }
        public List<Jobs> GetAllJobListings()
        {
            List<Jobs> jobListings = new List<Jobs>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = @"SELECT JobTitle, JobDescription, JobLocation, Salary, JobType, PostedDate 
                             FROM Jobs"; 

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Jobs job = new Jobs
                            {
                                JobTitle = reader["JobTitle"].ToString(),
                                JobDescription = reader["JobDescription"].ToString(),
                                JobLocation = reader["JobLocation"].ToString(),
                                Salary = Convert.ToDecimal(reader["Salary"]),
                                JobType = reader["JobType"].ToString(),
                                PostedDate = Convert.ToDateTime(reader["PostedDate"])
                            };

                            jobListings.Add(job);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while retrieving job listings: " + ex.Message);
                }
            }
            return jobListings;
        }
    }
}