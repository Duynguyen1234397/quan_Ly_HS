using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Danh_Sach_HS
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Tạo danh sách học sinh
                List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Thien", Age = 13 },
            new Student { ID = 2, Name = "Hieu", Age = 14 },
            new Student { ID = 3, Name = "Anh", Age = 16 },
            new Student { ID = 4, Name = "Cuong", Age = 15 },
            new Student { ID = 5, Name = "Ai", Age = 18 }
        };
                // A. In danh sách toàn bộ học sinh
                Console.WriteLine("Danh sach toan bo hoc sinh:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, " +
                        $"Age: {student.Age}");
                }
                // B. Tìm học sinh có tuổi từ 15 đến 18
                Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
                var ageFilter = students.Where(s => s.Age >= 15 && s.Age <= 18);
                foreach (var student in ageFilter)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, " +
                        $"Age: {student.Age}");
                }
                // C. Tìm học sinh có tên bắt đầu bằng chữ "A"
                Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A':");
                var nameFilter = students.Where(s => s.Name.StartsWith("A"));
                foreach (var student in nameFilter)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}," +
                        $" Age: {student.Age}");
                }
                // D. Tính tổng tuổi của tất cả học sinh
                int totalAge = students.Sum(s => s.Age);
                Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");
                // E. Tìm học sinh có tuổi lớn nhất
                int maxAge = students.Max(s => s.Age);
                var oldestStudent = students.First(s => s.Age == maxAge);
                Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.ID}," +
                    $" Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
                // F. Sắp xếp danh sách học sinh theo tuổi tăng dần
                Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan:");
                var sortedStudents = students.OrderBy(s => s.Age);
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}," +
                        $" Age: {student.Age}");
                }
            }
    }
}
