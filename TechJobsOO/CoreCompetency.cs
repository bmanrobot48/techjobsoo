using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private static int nextId = 1;

        // TODO: Change the fields to auto-implemented properties.
        public int ID { get; set; }
        public string Value { get; set; }

        public CoreCompetency()
        {
            ID = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   ID == competency.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
        }

        public override string ToString()
        {
            return Value;
        }
    }

    }

