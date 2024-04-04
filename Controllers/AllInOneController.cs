using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HWOneAndTwoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllInOneController : ControllerBase
    {
        [HttpGet]
         public string Math(string num1, string num2)
    {
        int number1 = 0;
        int number2 = 0;
        bool check1 = Int32.TryParse(num1, out number1);
        bool check2 = Int32.TryParse(num2, out number2);
        string non = "";
        if(check1 == false || check2 == false){
            non = "Error";
        }else{
            non = $"{num1} and {num2} is a sum of {number1 + number2} ";
        }
    return non;
    }


     [HttpGet("/Morning")]
   public string Morning(string Q1, string Q2)
    {
        return $"My name is {Q1}, I woke up at {Q2}";
    }  


    [HttpGet("/GreaterOrLess")]
    public string GreaterOrLess(int num1, int num2){
        string result;
if(num1 > num2){
    result = num1 + " is greater than " + num2 + " and " + num2 + " is less than" + num1;
}else if(num1 < num2) {
    result = num1 + " is less than " + num2 + " and " + num2 + " is greater than " + num1;
}else {
    result = num1 + " is equal to " + num2 + " both numbers are equal";

}
return result;
    }

    }
}