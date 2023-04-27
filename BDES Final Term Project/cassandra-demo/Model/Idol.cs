using Cassandra;

namespace cassandra_demo.Model
{
    internal class Idol
    {
        public Idol(string stageName, string fullName, LocalDate dateOfBirth, string group, string country,
            string birthPlace, string gender, string instagram)
        {
            StageName = stageName;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Group = group;
            Country = country;
            BirthPlace = birthPlace;
            Gender = gender;
            Instagram = instagram;
        }

        public string StageName { get; set; }
        public string FullName { get; set; }
        public LocalDate DateOfBirth { get; set; }
        public string Group { get; set; }
        public string Country { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public string Instagram { get; set; }
    }
}