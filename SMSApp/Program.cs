namespace SMSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Telebenin nomresini daxil ediniz");
            string studentNumber = Console.ReadLine();
            string fName="Nihad";
            string uName = ""; ;
            //float resultGrade = GetStudentInfo(studentNumber, out fName, out uName);

            float resultGrade2 = GetStudentInfo2(studentNumber, ref fName, ref uName);
        }
        public static float GetStudentInfo(string studentNumber, out string fullName, out string universityName)
        {

            float grade = 0;
            fullName = "";
            universityName = "";

            if (studentNumber == "1252")
            {
                fullName = "Huseyn Hesenli";
                universityName = "Ege unv";
                grade = 80;
            }

            else if (studentNumber == "1253")
            {
                fullName = "Semra Alb";
                universityName = "Iktisad unv";
                grade = 85;
            }
            else if (studentNumber == "1254")
            {
                fullName = "Nezrin Hesenova";
                universityName = "Azerbaycan Tec unv";
                grade = 78;
            }
            else if (studentNumber == "1255")
            {
                fullName = "Ugur Qasimoc";
                universityName = "Neft ve Senaye unv";
                grade = 100;
            }
            return grade;
        }
        public static float GetStudentInfo2(string studentNumber, ref string fullName, ref string universityName)
        {

            float grade = 0;

            if (studentNumber == "1252")
            {
                fullName = "Huseyn Hesenli";
                universityName = "Ege unv";
                grade = 80;
            }

            else if (studentNumber == "1253")
            {
                fullName = "Semra Alb";
                universityName = "Iktisad unv";
                grade = 85;
            }
            else if (studentNumber == "1254")
            {
                fullName = "Nezrin Hesenova";
                universityName = "Azerbaycan Tec unv";
                grade = 78;
            }
            else if (studentNumber == "1255")
            {
                fullName = "Ugur Qasimoc";
                universityName = "Neft ve Senaye unv";
                grade = 100;
            }
            return grade;
        }
    }
}