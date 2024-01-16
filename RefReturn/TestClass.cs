namespace RefReturn
{
    public class TestClass
    {
        int z = 9;

        public ref int GetZ()
        {
            return ref z;
        }
    }
}
