using TechTalk.SpecFlow;

namespace SpecSalad
{
    public abstract class ApplicationTask : TaskRole
    {
        public dynamic Role { get; set; }
        public Details Details { get; set; }

        public void StoreValue(string key, object value)
        {
            ScenarioContext.Current.Set(value, key);
        }

        public abstract object Perform_Task();
    }
}