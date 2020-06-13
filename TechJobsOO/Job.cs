using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        


        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }
 // TODO: Generate Equals() and GetHashCode() methods.


        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

     

        public override string ToString()
        {

            if(Name == null && EmployerName==null && EmployerLocation ==null&& JobType == null && JobCoreCompetency == null)
            {
                return "Job doesn't exist";
            }

            if(Name == "")
            {
                Name = "Data not available";
            }

            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }

            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }

            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            string testOutput = $"\nID:___{Id}_____\nName: __{Name}_____\nEmployer: __{EmployerName.Value}_____\nLocation: __{EmployerLocation.Value}_____\nPosition Type: ___{JobType.Value}____\nCore Competency: ___{JobCoreCompetency.Value}____;\n";

            return testOutput;
        } 

          
     }
}
