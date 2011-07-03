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

        [Obsolete("Please use the generic version of Retrieve")]
        public object Retrieve(string key)
        {
            if (ScenarioContext.Current.ContainsKey(key) == false)
                return null;

            return ScenarioContext.Current.Get<object>(key);
        }

        //protected T Retrieve<T>(string key)
        //{
        //    if (ScenarioContext.Current.ContainsKey(key) == false)                
        //        return (T) (object) null;

        //    return (T) ScenarioContext.Current.Get<object>(key);
        //}
    }
}