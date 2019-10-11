using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_02_Struct
{
    class StructTest
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            Student student;
            student.Name = "홍길동";
            student.Phone = "010-1111-1111";
            student.Age =13;
            student.Height = 173;
            student.Weight = 64;

            Console.WriteLine(student.Name);

            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine(point);

            Point3D p2 = new Point3D(100, 200, 300);
            Point3D p3 = p2;
            p3.z = 400;

            Console.WriteLine("{0} {1}", p2.z, p3.z);
        }
    }

}
