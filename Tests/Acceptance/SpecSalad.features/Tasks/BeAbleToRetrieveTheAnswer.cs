namespace SpecSalad.features.Tasks
{
    public class BeAbleToRetrieveTheAnswer :ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.GetStoredTaskAnswer();
        }
    }
}