namespace SpecSalad.features.Tasks
{
    public class RetrieveTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.Retrieve("the_value");
        }
    }
}