using System.Collections.Generic;

namespace TreDotNetApp.Models
{
    public class Project
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> techStack { get; set; }
        public string githubLink { get; set; }
        public string deployedLink { get; set; }
        public string completionDate { get; set; }
    }
}