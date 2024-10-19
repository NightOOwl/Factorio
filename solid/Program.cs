namespace solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var src1 = "test.email@example.com\r\ninvalid-email@com\r\nuser.name+filter@domain.co.uk";
            var src2 = "192.168.1.1\r\n255.255.255.255\r\n999.999.999.999";
            var src3 = "https://example.com\r\nhttp://localhost:3000\r\nhttps://192.168.0.1";
            var test1 = src1.FindStrRegex(@"\w+\.\w+@\w+\.com"); // test.email@example.com
            var test2 = src2.FindAllStrRegex(@"\d+\.\d+\.\d+\.\d+\.");
            var test3 = src1.FindAllStrRegex(@"(?<domain>@.+)\r", "domain");
        }

    }
}
