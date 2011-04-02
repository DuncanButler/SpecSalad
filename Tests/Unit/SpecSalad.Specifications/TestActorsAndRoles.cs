using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace SpecSalad.Specifications
{
    public class Butler : ApplicationRole
    {
        public void place_the_knife_on_the_right_of(string[] place)
        {
            place[1] = "knife";
        }

        public void place_the_fork_on_the_left_of(string[] place)
        {
            place[0] = "fork";
        }
    }


    public class SetThePlaceAtTheTable : ApplicationTask
    {        
        public override object Perform_Task()
        {
            var place = new string[2];

            Role.place_the_fork_on_the_left_of(place);
            Role.place_the_knife_on_the_right_of(place);

            return place;
        }
    }

    public class LayTheTable : ApplicationTask
    {
        public override object Perform_Task()
        {
            Match match = Regex.Match(Details.Value_Of("with_places_for"),@"\d");

            return int.Parse(match.Value);
        }
    }

    public class Something : ApplicationRole
    {
        public object do_action(ApplicationTask task_to_perform, object details)
        {
            throw new NotImplementedException();
        }
    }

    public class MoreThanOneWord : ApplicationRole
    {
        public object do_action(ApplicationTask task_to_perform, object details)
        {
            throw new NotImplementedException();
        }
    }
}