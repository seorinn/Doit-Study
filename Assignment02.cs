using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;

namespace DoitStudy.Assignments
{
    public class Assignment02 : IAssignment
    {
        public object main(object data){
            string[] strArr = {"123", "456", "111", "1", "-2", "33"}; // Ex:) strArr = {"123", "-123", "32"} 
            for(int i = 0; i<strArr.Length;i++){
                if(strArr[i]>strArr[i+1])
                
            }
            int res = 0; // Ex:) res = -91 위의 예제 기준 

            return res;
        }
    }
}