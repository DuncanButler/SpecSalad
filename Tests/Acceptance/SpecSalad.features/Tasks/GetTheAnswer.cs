namespace SpecSalad.features.Tasks
{
    public class GetTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.GetTheAnswer();
        }
    }
}