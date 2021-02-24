using System;
using System.Collections.Generic;

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

        public Job(string name, Employer empname, Location emploc, PositionType pt, CoreCompetency cc) : this()
        {
            Name = name;
            EmployerName = empname;
            EmployerLocation = emploc;
            JobType = pt;
            JobCoreCompetency = cc;
        }

        public override string ToString()
        {
            
            string output = "\n";

            output += $"ID: {this.Id}\n";

            if (string.IsNullOrEmpty(this.Name))
            {
                output += "Name: Data not available\n";
            }
            else
            {
                output += $"Name: {this.Name}\n";
            }

            if (string.IsNullOrEmpty(this.EmployerName.Value))
            {
                output += "Employer: Data not available\n";
            }
            else
            {
                output += $"Employer: {this.EmployerName}\n";
            }

            if (string.IsNullOrEmpty(this.EmployerLocation.Value))
            {
                output += "Location: Data not available\n";
            }
            else
            {
                output += $"Location: {this.EmployerLocation}\n";
            }

            if (string.IsNullOrEmpty(this.JobType.Value))
            {
                output += "Position Type: Data not available\n";
            }
            else
            {
                output += $"Position Type: {this.JobType}\n";
            }

            if (string.IsNullOrEmpty(this.JobCoreCompetency.Value))
            {
                output += "Core Competency: Data not available\n";
            }
            else
            {
                output += $"Core Competency: {this.JobCoreCompetency}\n";
            }
            return output;
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
        
    }
}
