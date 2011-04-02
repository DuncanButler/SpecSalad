using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SpecSalad
{
    public interface Details
    {
        string Value_Of(string specific);
    }

    public class NeedingSpecifics : Details
    {
        Dictionary<string,string> info = new Dictionary<string, string>();

        public void Understand_The(string details)
        {
            if (string.IsNullOrEmpty(details))
                return;

            var result = Regex.Matches(details,"[^']+");
            
            for (int i = 0; i < result.Count; i+=2)
            {
                if(i + 1 < result.Count )
                    info.Add(symbolise_name(result[i].Value),result[i+1].Value.Trim());
                else
                    info.Add(symbolise_name(result[i].Value), result[i].Value.Trim());                    
            }
        }

        public string Value_Of(string specific)
        {
            if(info.ContainsKey(specific))
                return info[specific];

            return string.Empty;
        }

        string symbolise_name(string name)
        {
            name = name.Trim();

            name = name.Replace(' ', '_');

            return name;
        }
    }
}