namespace Examples.LSP
{
    public abstract class BaseClass
    {
        // precondition: given a positive integer
        public virtual int GetEvenNumber(int value)
        {
            return value * 2;
        }
        // return an positive even integer
    }
}
