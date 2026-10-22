namespace Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 2.3: Egyptian Phone & National ID Validation Tests ===");
            Console.WriteLine();

            var PhoneTests = new (string input, bool expected)[]
            {
             ("01012345678", true),
             ("+201512345678", true),
             ("01312345678", false),
             ("0101234567", false),
             ("0101234567a", false),
             (null, false),
             ("   ", false)
            };

            var idTests = new (string Input, bool Expected)[]
            {
            ("29901011234567", true),
            ("19901011234567", false),
            ("2990101123456", false),
            (null, false),
            ("", false)
            };
            Console.WriteLine("--- Egyptian Phone Number Tests ---");
            foreach (var (input, expected) in PhoneTests)
            {
                var actual = input.IsValidEgyptianPhone(); 
                var pass = actual == expected ? "PASS" : "FAIL";
                Console.WriteLine($"[{pass}] Input: \"{input ?? "null"}\" | Expected: {expected} | Actual: {actual}");
            }

            Console.WriteLine();
            Console.WriteLine("--- Egyptian National ID Tests ---");
            foreach (var (input, expected) in idTests)
            {
                var actual = input.IsValidEgyptianNationalId(); 
                var pass = actual == expected ? "PASS" : "FAIL";
                Console.WriteLine($"[{pass}] Input: \"{input ?? "null"}\" | Expected: {expected} | Actual: {actual}");
            }
        }
    }
}
