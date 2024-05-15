using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TutorialHub.Models
{
    public class TutorialsModel
    {
        [DataMember(Name = "tutorials")]
        public Tutorials Tutorials { get; set; }
    }

    public class Stream
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "iframe")]
        public string Iframe { get; set; }
    }

    public class Tutorials
    {
        [DataMember(Name = "stream")]
        public List<Stream> Stream { get; set; }
    }

}