 public static class LogAnalysis
 {
     public static string SubstringAfter(this string input, string a)
     {
         int index = input.IndexOf(a);
         return input.Substring(index+a.Length);
     }
     public static string SubstringBetween(this string input, string a, string b)
     {
         string res = "";
         int index1 = input.IndexOf(a);
         int index2 = input.IndexOf(b);
         for (int i = index1+ a.Length; i < index2; i++)
         {
             res += input[i];
         }
         return res;
     }
     public static string Message(this string input)
     {
         string res = "";
         int index = input.IndexOf(':');
         for (int i = index+2; i < input.Length; i++)
         {
             res += input[i];
         }
         return res;
     }
     public static string LogLevel(this string input)
     {
         string res = "";
         int index1 = input.IndexOf("[");
         int index2 = input.IndexOf("]");
         for (int i = index1+1; i < index2; i++)
         {
             res += input[i];
         }
         return res;
     }
     // TODO: define the 'SubstringAfter()' extension method on the `string` type

     // TODO: define the 'SubstringBetween()' extension method on the `string` type

     // TODO: define the 'Message()' extension method on the `string` type

     // TODO: define the 'LogLevel()' extension method on the `string` type
 }
