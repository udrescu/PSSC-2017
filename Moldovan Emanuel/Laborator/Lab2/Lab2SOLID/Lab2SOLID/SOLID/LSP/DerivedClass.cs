using System;

namespace Examples.LSP
{
    public class DerivedClass : BaseClass
    {
        // precondition: given any integer (positive or negative)
        public override int GetEvenNumber(int value)
        {
            return Math.Abs(value) * 2 * 4;
        }
        // postcondition: return an positive even integer divisible with 4
    }
}
