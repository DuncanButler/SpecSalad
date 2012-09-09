namespace SpecSalad.features.Tasks
{
    public class UpVoteTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.UpVoteAnswer(Details.Value());

            return null;
        }
    }
}