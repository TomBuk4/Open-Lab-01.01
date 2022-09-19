using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int num_input = int32.Parse(Input);
                
            if (num_input < 10) {
                return true;
            }
            else {
                return False;
                
            throw new NotImplementedException();
        }
    }
}
