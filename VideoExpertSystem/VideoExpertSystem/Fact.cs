using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class Fact
    {
        public string Description { get; set; }
        public string Id { get; set; }

        public Dictionary<string, bool> Value { get; set; }

        public HashSet<String> SetOfId { get; set; }

        

        public Fact(string description, string id)
        {
            Description = description;
            Id = id;
            this.Value = new Dictionary<string, bool>();
            this.SetOfId = new HashSet<string>();
        }
        
        public HashSet<String> GetIdHashSet()
        {
            return this.SetOfId;
        }

        public void SetFactValueById(String id, bool value)
        {
            Value[id] = value;
        }

        public bool GetValueById(String id)
        {
            return Value[id];
        }

        public string GetDescription()
        {
            return this.Description;
        }
    }
}
