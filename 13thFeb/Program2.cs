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
        var students = _enrollments[course];

    // capacity check
    if (students.Count >= course.MaxCapacity)
        return false;

    // already enrolled
    if (students.Contains(student))
        return false;

    // prerequisite check (if LabCourse)
    if (course is LabCourse lab &&
        student.Semester < lab.RequiredSemester)
        return false;

    students.Add(student);
    return true;
    
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
        return _enrollments.Where(e=>e.Value.Contains(student)).Select(e=>e.Key);
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
        if (grade < 0 || grade > 100)
        throw new ArgumentException("Invalid grade");

             _grades[(student, course)] = grade;
    }
    
// TODO: Calculate GPA for student
    public double? CalculateGPA(TStudent student)
    {
        // Weighted by course credits
        // Return null if no grades
        var studentGrades = _grades
        .Where(g => g.Key.Item1.Equals(student))
        .ToList();

        if (!studentGrades.Any())
            return null;

        return studentGrades.Average(g => g.Value);
    }
    
    // TODO: Find top student in course
    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        // Return student with highest grade
        // return _grades.Where(g=>g.Key.Item2.Equals(course)).OrderByDescending(g=>g.Value).FirstOrDefault().Key;

        var result = _grades
        .Where(g => g.Key.Item2.Equals(course))
        .OrderByDescending(g => g.Value)
        .FirstOrDefault();

        if (result.Equals(default(KeyValuePair<(TStudent, TCourse), double>)))
            return null;

        return (result.Key.Item1, result.Value);
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



