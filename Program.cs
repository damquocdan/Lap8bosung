namespace Lap8bosung
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {studentId="SV001",
                    studentName="Nguyễn Văn A",
                    age=20,sex=true,
                    birthDate="04-04-2002",
                    birthPlace="HN",
                    address="25 Vũ Ngọc Phan"},
                new Student() {studentId="SV002",
                    studentName="Nguyễn Văn B",
                    age=21,sex=false,
                    birthDate="02-04-2001",
                    birthPlace="BN",
                    address="25 Tiến Bào"},
                new Student() {studentId="SV003",
                    studentName="Nguyễn Văn C",
                    age=22,sex=true,
                    birthDate="04-04-2000",
                    birthPlace="HCM",
                    address="25 Phù Khê"},
                new Student() {studentId="SV004",
                    studentName="Nguyễn Văn D",
                    age=23,sex=true,
                    birthDate="04-04-1999",
                    birthPlace="HP",
                    address="25 Từ Sơn"},
            };
            IEnumerable<Student> st = from s in students select s;
            // Duyệt và in ra
            foreach (var s in st ) {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("Danh sách các sinh viên có tuổi nằm trong khoảng 20-30");
            // Lọc tất cả các khách hàng có tuổi nằm trong khoảng 20-30
            var listcust = from s in students where s.age>20&&s.age<30 select s;
            foreach (var s in listcust )
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}