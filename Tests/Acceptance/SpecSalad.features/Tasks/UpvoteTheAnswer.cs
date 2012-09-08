namespace SpecSalad.features.Tasks
{
    public class UpvoteTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.UpVoteAnswer(Details.Value());

            return null;
        }
    }
}