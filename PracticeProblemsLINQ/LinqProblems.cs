using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
         
            var listOfWords = words.Where(w => w.Contains("th")).ToList();
            foreach (var word in listOfWords)
            {
                Console.WriteLine(word);
            }
            //return
            return listOfWords;

        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code

            var listOfNames = from n in names.Distinct() select n;

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
            //return
            return names;
            //var displayListOfNames = names.Aggregate((s1,s2)=> s1 + ", " + s2);
            //Console.WriteLine(displayListOfNames);
            //return names;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
          
        
            var query = from customer in customers where customer.FirstName == "Mike" select customer;
            foreach(var customer in query)
            {
                Console.WriteLine(customer);
            }
            //return
            return RunProblem3(customers) ;
          
        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
           customers = new List<Customer>();
            var selections = from num in customers where num.Id == 3 select num;

            Console.WriteLine();
            foreach (Customer selection in selections)
            {
                Console.WriteLine("Id: {0}, new last name: {1}, new first name {2}",selection.Id, "Smith", "Bill");
            }

            //return
            return RunProblem4(customers);
          
        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            //       "80,100,92,89,65", 
            //       "93,81,78,84,69",
            //       "73,88,83,99,64",
            //       "98,100,66,74,55"
            //code
            var stringList = new List<string>();
            double result = stringList.Sum(x => x.Length) - stringList.Min(x => x.Length);
            var averages = classGrades.Cast<double>().GroupBy(x => result).Select(c => c.Average()).ToList();
           
            //return
            return result;

        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            string letters = "terrill";
            //code
            IEnumerable<string> wordAscending = from w in letters orderby word select word;
            foreach (var singleLetter in wordAscending)
            {
                Console.WriteLine(singleLetter);
            }

            //return
            return word;

        }
        #endregion
    }
}
