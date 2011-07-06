using System;
using TechTalk.SpecFlow;

namespace SpecSalad
{
    public class ApplicationRole :TaskRole
    {
        public void StoreValue(string key, object value)
        {
            ScenarioContext.Current.Set(value, key);
        }

        public object Retrieve(string key)
        {
            if (ScenarioContext.Current.ContainsKey(key) == false)
                return null;

            return ScenarioContext.Current.Get<object>(key);
        }
    }
}