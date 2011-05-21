using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class DoTheReturnTask : ApplicationTask
    {
        readonly List<string> _knownParameterNames = new List<string>
                                                         {
                                                             "with_a_single_parameter",
                                                             "with_parameter",
                                                             "and_parameter"
                                                         };

        public override object Perform_Task()
        {
            foreach (var parameterName in _knownParameterNames)
            {
                int paramValue;
                int.TryParse(Details.Value_Of(parameterName), out paramValue);

                Role.Add(paramValue);
            }

            return true;
        }
    }
}