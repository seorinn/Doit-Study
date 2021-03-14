using System;

namespace doit_study_homework_template
{
    public class HW03 : homework
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public HW03(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var A = 10;
            var B = 4;

            /* 여기에 코드를 작성하세요 */
            var a = A+B;
            var b = A-B;
            var c = A*B;
            var d = A/B;
            var e = A%B;
            Console.Write("A+B="+a);
            Console.Write(", A-B="+b);
            Console.Write(", A*B="+c);
            Console.Write(", A/B="+d);
            Console.Write(", A%B="+e);
        }
    }
}