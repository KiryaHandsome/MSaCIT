using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project
{
    //class which analyze C++ code and calculate Holsted metrics
    public class HolstedMetrics
    {
        private static HashSet<string> operators = new HashSet<string>()
        {
            "+", "-", "*", "/", "%", "++", "==", "!=", "&&", ">=", "<=",
            "||", "|", "^", "~", "<<", ">>", "sizeof", ",", ";", "goto",
            "break", "continue", "return", "delete", "cout", "cin"
        };

        private static Dictionary<Regex, string> operators_regexes = new Dictionary<Regex, string>()
        {
            { new Regex("\\s+<\\s+"), "<" },                    //less
            { new Regex("\\s+>\\s+"), ">" },                    //more
            { new Regex("\\s+&\\s+"), "&" },                    //bitwise and
            { new Regex("\\s+\\|\\s+"), "|" },                  //bitwise or
            { new Regex("(\\B+)\\s*\\(.+\\)"), "( )" },         //brackets
            { new Regex("for\\s*\\(.+\\)"), "for(...)" },       //for loop 
            { new Regex("(else){0}\\s+if\\s*\\(.+\\)"), "if(...)" },  //if
            { new Regex("while\\s*\\(.+\\)"), "while(...)" },         //while loop
            { new Regex("do\\s*\\{([\\s\\S]+?)(\\s*)(.*)\\n(.*)\\}\\s*while"), "do while(...)" }//do while loop
        };

        private static Regex variable_regex = new Regex("()\\b((?:const\\s*|unsigned\\s*|signed\\s*|static\\s*|void\\s*|short\\s*|long\\s*|char\\s*|int\\s*|float\\s*|double\\s*|bool\\s*)+)(?:\\s+\\*?\\*?\\s*)([a-zA-Z_][a-zA-Z0-9_]*)\\s*[\\[;,=)]");
        private static Regex function_regex = new Regex("(\\w+)\\(.*\\)");

        public static Dictionary<string, int> FindOperators(string code)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> lexemes = code.Split(new char[] { ' ', '\n', '\r', '\t'},
                StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string lexeme in lexemes)
            {
                foreach(string op in operators)
                {
                    if(lexeme.Contains(op))
                    {
                        if (!dict.ContainsKey(op)) dict.Add(op, 1);
                        else dict[op]++;
                    }
                }
            } 
            foreach(var pair in operators_regexes)
            {
                MatchCollection match = pair.Key.Matches(code);
                if (match.Count != 0)
                {
                    dict.Add(pair.Value, match.Count);
                }
            }
            Match match_function = function_regex.Match(code);
            while (match_function.Success)
            {
                string func_name = match_function.Groups[1].Value + "()";
                if (!dict.ContainsKey(func_name)) dict.Add(func_name, 1);
                else dict[func_name]++;
                match_function = match_function.NextMatch();
            }
            return dict.OrderBy(p => p.Value).Reverse().ToDictionary(p => p.Key, p => p.Value);
        }

        public static Dictionary<string, int> FindOperands(string code)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] lines = code.Split('\n');
            foreach (string line in lines)
            {
                string cleanedLine = RemoveCommentsAndWhitespace(line);
                foreach(var pair in dict)
                {
                    if(cleanedLine.Contains(pair.Key)) dict[pair.Key] = pair.Value + 1;
                }
                Match match = variable_regex.Match(cleanedLine);
                while (match.Success)
                {
                    string variable_name = match.Groups[3].Value;
                    if (!dict.ContainsKey(variable_name)) dict.Add(variable_name, 1);
                    else dict[variable_name]++;
                    match = match.NextMatch();
                }
            }
            return dict.OrderBy(p => p.Value).Reverse().ToDictionary(p => p.Key, p => p.Value);
        }

        static string RemoveCommentsAndWhitespace(string line)
        {
            int commentIndex = line.IndexOf("//");
            if (commentIndex >= 0)
            {
                line = line.Substring(0, commentIndex);
            }
            return line.Trim();
        }
    }

}

