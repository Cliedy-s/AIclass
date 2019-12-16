using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1210_Python_CSharp_Connect
{
    class PythonFromFile
    {
        static void Main(string[] args)
        {
            //엔진 생성
            Microsoft.Scripting.Hosting.ScriptEngine engine = IronPython.Hosting.Python.CreateEngine();
            Microsoft.Scripting.Hosting.ScriptScope scope = engine.CreateScope();
            try
            {
                //파일 실행
                Microsoft.Scripting.Hosting.ScriptSource source = engine.CreateScriptSourceFromFile("sample.py");
                dynamic result = source.Execute(scope);

                #region string GetString()
                //함수명 : GetString
                //반환값 : string
                //Return값으로 Hello World 반환
                var GetString = scope.GetVariable<Func<string>>("GetString");
                MessageBox.Show(GetString());
                #endregion

                #region int Sum( num1, num2 )
                //함수명 : Sum
                //반환값 : int
                //Return값으로 num1 + num2 반환
                var Sum = scope.GetVariable<Func<int, int, int>>("Sum");
                MessageBox.Show((Sum(1, 2)).ToString());
                #endregion

                #region void GetList1(IronPython.Runtime.List)
                //함수명 : GetList1
                //반환값 : IronPython.Runtime.List
                //Return값으로 리스트반환(리턴받아서 사용하지 않아도 됨) 매개변수로 넣은 리스트에 3개의 아이템을 넣어줌
                var GetList1 = scope.GetVariable<Func<object, IronPython.Runtime.List>>("GetList1");
                IronPython.Runtime.List list = new IronPython.Runtime.List();
                list.Add("추가항목");
                GetList1(list);
                foreach (string data in list)
                {
                    MessageBox.Show("result: {" + data + "}");
                }
                #endregion

                #region IronPython.Runtime.List GetList2()
                //함수명 : GetList2
                //반환값 : IronPython.Runtime.List
                //Return값으로 리스트를 생성하고 리스트에 3개의 아이템을 넣어서 반환
                var GetList2 = scope.GetVariable<Func<IronPython.Runtime.List>>("GetList2");
                IronPython.Runtime.List a = GetList2();
                foreach (string data in a)
                {
                    MessageBox.Show("result: {" + data + "}");
                }
                #endregion

                #region class World
                ///클래스명 : World 
                ///다양한 함수를 가지고 있음
                dynamic world = scope.GetVariable("World")();
                //python으로 출력창에 "Hello" 출력
                world.hello();
                //생성자에서 등록된 name를 출력
                MessageBox.Show(world.getName() as string);
                //add 함수의 결과값 출력
                int r = (int)(world.add(10, 20));
                MessageBox.Show(r.ToString());
                world.setName("홍길동");
                MessageBox.Show(world.getName() as string);
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
