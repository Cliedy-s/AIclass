using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExample
{
    class Program
    {
        static TraceSource trace = new TraceSource("MyTrace");
        static void Main(string[] args)
        {
            string sProdName = "Widget";
            int iUnitQty = 100;
            double dUnitCost = 1.03;

            trace.TraceEvent(TraceEventType.Information,0,("Debug 제품정보 시작----"));
            Trace.Indent();

            trace.TraceInformation($"제품명 : {sProdName}");
            trace.TraceInformation($"단위수량 : {iUnitQty}");
            trace.TraceInformation($"단가 : {dUnitCost}");
            trace.Flush();

            //조건이 true일때만 출력.
            Debug.WriteLineIf(iUnitQty > 50, "수량이 충분");
            Debug.WriteLineIf(iUnitQty < 50, "수량이 부족");

            //조건이 false일때만 출력. 호출스택을 메세지박스로 보여준다.
            Debug.Assert(iUnitQty > 50, "수량이 충분");
            //Debug.Assert(iUnitQty < 50, "수량이 부족");

            /*
            DefaultTraceListener - 디버그창
            TextWriterTraceListener - 파일(TextWriter,Stream으로 메세지를 보냄)
            ConsoleTraceListener - 콘솔
            EventLogTraceListener - 윈도우즈의 이벤트로그
            */

            //TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            //Debug.Listeners.Add(tr1);
            //TextWriterTraceListener tr2 = new TextWriterTraceListener(System.Console.Out);
            //Debug.Listeners.Add(tr2);

            Debug.WriteLine($"제품명2 : {sProdName}");
            Debug.WriteLine($"단위수량2 : {iUnitQty}");
            Debug.WriteLine($"단가2 : {dUnitCost}");
            Debug.Flush();

            Console.ReadLine();
        }
    }
}
