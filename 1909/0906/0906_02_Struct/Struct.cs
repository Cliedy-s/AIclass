using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_02_Struct
{
    /// <summary>
    /// 3차원 좌표값 스트럭쳐
    /// </summary>
    struct Point3D
    {
        public int x, y, z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", x, y, z);
        }
    }

    /// <summary>
    ///  학생 
    /// </summary>
    struct Student
    {
        public string Name;
        public string Phone;
        public int Age;
        public int Height;
        public int Weight;

        public Student(string Name, string Phone, int Age, int Height, int Weight)
        { // 생성자가 하나 작성되거나 아니거나
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;
        }
    }
}
