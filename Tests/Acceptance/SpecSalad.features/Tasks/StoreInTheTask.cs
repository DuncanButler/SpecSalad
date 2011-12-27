namespace SpecSalad.features.Tasks
{
    public class StoreInTheTask : ApplicationTask
    {
        public override object Perform_Task()
        {
            StoreValue("FromTask",  Details.Value());

            return null;
        }
    }
}