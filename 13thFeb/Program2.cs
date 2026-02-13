// Scenario 2: University Course Registration System
// Problem: Design a type-safe course registration system with constraints on student enrollment.
// csharp
// Base constraints
public interface IStudent
{
    int StudentId { get; }
    string Name { get; }
    int Semester { get; }
}

public interface ICourse
{
    string CourseCode { get; }
    string Title { get; }
    int MaxCapacity { get; }
    int Credits { get; }
}

// 1. Generic enrollment system
public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<TCourse, List<TStudent>> _enrollments = new();
    
    // TODO: Enroll student with constraints
    public bool EnrollStudent(TStudent student, TCourse course)
    {
        // Rules:
        // - Course not at capacity
        // - Student not already enrolled
        // - Student semester >= course prerequisite (if any)
        // - Return success/failure with reason
        if(course.MaxCapacity <= _enrollments.Values.Sum(s=>s.Count) && !_enrollments.Contains(student) && student.Semester >= 1)
        {
            if (!_enrollments.ContainsKey(course))
            {
                _enrollments[course] = new List<TStudent>();
            }
            _enrollments[course].Add(student);
            return true;
        }
        else
        {
            return false;
        }
    
    }

 // TODO: Get students for course
    public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
    {
        // Return immutable list
        if (_enrollments.ContainsKey(course))
        {
            return _enrollments[course].AsReadOnly();
        }
        else
        {
            return new List<TStudent>().AsReadOnly();
        }
    }
    
    // TODO: Get courses for student
    public IEnumerable<TCourse> GetStudentCourses(TStudent student)
    {
        // Return courses student is enrolled in
        return _enrollments.Where(e=>e.Value.Contains(student)).Select(e=>e.key);
    }
    
    // TODO: Calculate student workload
    public int CalculateStudentWorkload(TStudent student)
    {
        // Sum credits of all enrolled courses
        return _enrollments.Where(e=>e.Value.Contains(student)).Sum(e=>e.Key.Credits);
    }
}

// 2. Specialized implementations
public class EngineeringStudent : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string Specialization { get; set; }
}

public class LabCourse : ICourse
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int MaxCapacity { get; set; }
    public int Credits { get; set; }
    public string LabEquipment { get; set; }
    public int RequiredSemester { get; set; } // Prerequisite
}

// 3. Generic gradebook
public class GradeBook<TStudent, TCourse>
{
    private Dictionary<(TStudent, TCourse), double> _grades = new();
    
    // TODO: Add grade with validation
    public void AddGrade(TStudent student, TCourse course, double grade)
    {
        // Grade must be between 0 and 100
        // Student must be enrolled in course
        if(grade>=0 && grade <= 100 && _enrollments.ContainsKey(course) && _enrollments[course].Contains(student))
        {
            _grades[(student,course)] = grade;
        }
    }
    
// TODO: Calculate GPA for student
    public double? CalculateGPA(TStudent student)
    {
        // Weighted by course credits
        // Return null if no grades
        return _grades.Where(g=>g.Key.Item1.Equals(student)).Average(g=>g.Value);
    }
    
    // TODO: Find top student in course
    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        // Return student with highest grade
        return _grades.Where(g=>g.Value.Item2.Eqwals(course)).OrderByDescending(g=>g.Value).FirstOrDefault().Key;
    }
}

// 4. TEST SCENARIO: Create a simulation
// a) Create 3 EngineeringStudent instances
// b) Create 2 LabCourse instances with prerequisites
// c) Demonstrate:
//    - Successful enrollment
//    - Failed enrollment (capacity, prerequisite)
//    - Grade assignment
//    - GPA calculation
//    - Top student per course



