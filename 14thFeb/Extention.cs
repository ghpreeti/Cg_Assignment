using System;

// Scenario
// An enterprise application uses plain strings for logging.
// You are not allowed to modify the existing logging class.
// Problem Statement
// Create extension methods for the string class to enhance logging.
// Requirements
// Implement extension methods:
// •	ToInfoLog()
// •	ToWarningLog()
// •	ToErrorLog()
// Behavior
// "User logged in".ToInfoLog();
// Output
// [INFO] [2026-02-09 10:30:22] User logged in
// Constraints
// •	Extension methods must be in a static class
// •	Timestamp must be generated dynamically
// •	No inheritance allowed


public static class Extension
{
    public static void ToInfoLog(this string message)
    {
        Console.WriteLine($"[INFO] [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }

    public static void ToWarningLog(this string message)
    {
        Console.WriteLine($"[WARNING] [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }

    public static void ToErrorLog(this string message)
    {
        Console.WriteLine($"[ERROR] [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }

    public static void Main()
    {
        "User logged in".ToInfoLog();
        "Disk space low".ToWarningLog();
        "Database connection failed".ToErrorLog();
    }
}
