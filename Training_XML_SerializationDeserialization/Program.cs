

using System.Xml.Serialization;

namespace Training_XML_SerializationDeserialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SerizalizeObjectToXmlString();
            Console.WriteLine("\nprocess completed...\n");

            SerializeListToXmlFile();

            DeserializeXmlFileToList();

            Console.WriteLine("\nprocess completed...\n");

            DeserializeXmlFileToObject();

            Console.ReadKey();
        }

        private static void SerizalizeObjectToXmlString()
        {
            var member = new Member()
            {
                Name = "james",
                Email = "james@postmail.org",
                Age = 43,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = true
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));

            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);

                var xmlContent = writer.ToString();

                Console.WriteLine(xmlContent);

                DeserializeXmlStringToObject(xmlContent);

            }

            SerializeObjectToXmlFile(member);
        }

        private static void SerializeObjectToXmlFile(Member member)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));

            using (var writer = new StreamWriter("member.xml"))
            {
                xmlSerializer.Serialize(writer, member);
            }
        }

        private static void SerializeListToXmlFile()
        {
            var memberList = new List<User>()
            {
                new User()
                {
                    Name = "nuna",
                    Email = "nuna@email.org",
                    Age = 32,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                },
                new User()
                {
                    Name = "zumpel",
                    Email = "zumpelsmail@superemail.org",
                    Age = 29,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new User()
                {
                    Name = "hal9000",
                    Email = "hal9000@jupiter.org",
                    Age = 6,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(List<User>));

            using (var writer = new StreamWriter("memberList.xml"))
            {
                xmlSerializer.Serialize(writer, memberList);
            }
        }

        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer (typeof(List<User>));

            using(var reader = new StreamReader("memberList.xml"))
            {
                var users = (List<User>)xmlSerializer.Deserialize(reader);

                Console.WriteLine("\nUsers:\n");

                foreach (User user in users)
                {
                    Console.WriteLine(user.ToString());
                }                
            }            
        }

        private static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));

            using(var writer = new StreamReader("member.xml"))
            {
                var member = (Member)xmlSerializer.Deserialize(writer);

                Console.WriteLine(member.ToString());
            }
        }

        private static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));

            using(var reader = new StringReader(xmlString))
            {
                var member = xmlSerializer.Deserialize(reader) as Member;
            }
        }
    }
}