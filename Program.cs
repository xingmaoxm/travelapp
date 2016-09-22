using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input of the Gherkin Syntax file to be tested
            string filename = "/xm/_test.feature";

            //Servername
            string _servername = "";

            //Content-Type of HTTP request header
            string _contenttype = "";

            //Validation result
            Boolean _validate = true;

            //Response of Http request 
            List<string> _response = new List<string>();

            //Instantiation of the Gherkintest Class
            var newtest = new Gherkintest(filename);

            //Call the function for the "Given" Step
            _servername = newtest.getServername();

            //Call the function for the "And" Step
            _contenttype = newtest.getContentType();

            //Call the function for the "When" Step
            _response = newtest.getRequest(_servername, _contenttype);

            //Call the function for the "Then" Step
            _validate = newtest.validate(_response);

            //Output of the test result
            Console.WriteLine("The test result is " + _validate);
        }
    }
}
