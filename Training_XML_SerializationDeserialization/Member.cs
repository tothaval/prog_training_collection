using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training_XML_SerializationDeserialization
{
    [Serializable]
    [XmlRoot("MemberDetails")]
    public class Member
    {
        [XmlElement("MemberName")]
        public string Name { get; set; }
        [XmlElement("MemberEmailAddress")]
        public string Email { get; set; }
        public int Age { get; set; }

        [XmlIgnore]
        public DateTime JoiningDate { get; set; }

        [XmlAttribute("PlatinumMember")]
        public bool IsPlatinumMember { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Email: {Email}\n" +
                $"Age: {Age}\n" +
                $"Joined: {JoiningDate}\n" +
                $"Platinum: {IsPlatinumMember}\n";
        }
    }
}
