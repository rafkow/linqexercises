
namespace LinqExercises 
{
    public class CsvReader {
        public static List<Person> ReadCsv(string filePath) {
            List<Person> persons = new List<Person>();

            using(var reader = new StreamReader(filePath)) {
                while(!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var person = new Person {
                        FirstName=values[0].Trim('"'),
                        LastName=values[1].Trim('"'),
                        CompanyName=values[2].Trim('"'),
                        Address=values[3].Trim('"'),
                        City=values[4].Trim('"'),
                        County=values[5].Trim('"'),
                        State=values[6].Trim('"'),
                        Zip=values[7].Trim('"'),
                        Phone1=values[8].Trim('"'),
                        Phone2=values[9].Trim('"'),
                        Email=values[10].Trim('"'),
                        Web=values[11].Trim('"')
                    };
                    persons.Add(person);
                }
            }

            return persons;
        }
    }


    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Path.GetFullPath(@"dane.csv"));
            List<Person> people = CsvReader.ReadCsv(Path.GetFullPath(@"dane.csv"));

            // Użyj Linq to utworzenia tablicy ludzi z imieniem zaczynającym się na A

            // Użyj linq do odfiltrowania ludzi mających email z domeny google.com
        }
    }
}
