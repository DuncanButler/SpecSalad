namespace SpecSalad.features.Tasks
{
    public class DoTheSubtractOneTask : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.SubtractOne();

            return null;
        }
    }
}