using System;

namespace _23011556_029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EVENODD obj1 = new EVENODD();
            obj1.EvenOdd();

            CALCULATOR obj2 = new CALCULATOR();
            obj2.calculator();

            GRADE_EVALUATOR obj3 = new GRADE_EVALUATOR();
            obj3.grade();

            SUM_OF_N obj4 = new SUM_OF_N();
            obj4.sum();

            MULTILPICATION_TABLE obj5 = new MULTILPICATION_TABLE();
            obj5.table();

            FACTORIAL obj6 = new FACTORIAL();
            obj6.factorial();

           REVERSE obj7 = new REVERSE();
            obj7.reverse();

            MINMAX obj8 = new MINMAX();
            obj8.array();

            ARRAY_COUNT obj9 = new ARRAY_COUNT();
            obj9.evenodd();

            ARRAY_SEARCH obj10 = new ARRAY_SEARCH();
            obj10.search();
        }
    }
}
