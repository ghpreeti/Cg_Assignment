namespace MVC_CORE_WebApp1.Models
{
    public class StudentRepo : IRepo<Student>
    {
        public static List<Student> studList = null;
         public StudentRepo()
        {
            if (studList == null)
            {
                studList = new List<Student>()
            {
                new Student(){RollNo=1,Name="John",Age=20,Address="123 Main St"},
                new Student(){RollNo=2,Name="Alice",Age=22,Address="456 Elm St"},
                new Student(){RollNo=3,Name="Bob",Age=19,Address="789 Oak St"}
            };
            }
        }
        public bool AddData(Student obj)
        {
            bool flag = false;
            if(obj!=null)
            {
                studList.Add(obj);
                flag = true;
            }
            else
            {
                throw new NullReferenceException("Object is null");
            }
            return flag;
            
        }

        public bool DeleteData(int id)
        {
            bool flag = false;
            Student sObj = studList.Find(s => s.RollNo == id);
            if (sObj != null)
            {
                studList.Remove(sObj);
                flag = true;
            }
            else
            {
                throw new KeyNotFoundException("Student with the given ID not found");
            }
            return flag;
        }

        public List<Student> GetAllData()
        {
            return studList;
        }

        public Student GetDataById(int id)
        {
            Student sObj = studList.Find(s => s.RollNo == id);
            return sObj;
        }

        public bool UpadateData(int id, Student obj)
        {
            bool flag = false;
            Student sObj = studList.Where(s => s.RollNo == id).FirstOrDefault();
            if (sObj != null) 
            {
                sObj.RollNo = id;
                sObj.Name = obj.Name;
                sObj.Age = obj.Age;
                sObj.Address = obj.Address;

                flag = true;
            }
            return flag;
        }
    }
}
