namespace SpecSalad.features.Tasks
{
    public class Store : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.StoreValue("the_value", Details.Value_Of("the_value"));

            return null;
        }
    }
}