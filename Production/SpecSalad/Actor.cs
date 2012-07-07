namespace SpecSalad
{
    public class Actor
    {
        readonly Director _directed_by;
        ApplicationRole _currentApplicationRole;
        ApplicationTask _current_task;
        NeedingSpecifics _specifics;

        public Actor(string this_type_of_role, Director directed_by)
        {
            _directed_by = directed_by;

            get_ready_to_perform(this_type_of_role);
        }

        public void Perform(string task_descripiton, string details = null)
        {
            setup_task(task_descripiton, details);

            _current_task.Perform_Task();
        }

        public object Answer(string task_description, string details = null)
        {
            setup_task(task_description, details);

            return _current_task.Perform_Task();            
        }

        void setup_task(string task_descripiton, string details)
        {
            get_ready_to_perform(task_descripiton);

            _specifics = new NeedingSpecifics();

            if(string.IsNullOrWhiteSpace(details) == false)
                _specifics.Understand_The(details);

            _current_task.Details = _specifics;
            _current_task.Role = _currentApplicationRole;           
        }

        void get_ready_to_perform(string something)
        {
            var the_thing = _directed_by.How_Do_I_Perform(something);

            if (the_thing == null)
                return;

            see_how_i_do(the_thing);
        }

        void see_how_i_do(TaskRole something)
        {
            if (something is ApplicationTask)
                _current_task = (ApplicationTask)something;

            if (something is ApplicationRole)
                _currentApplicationRole = (ApplicationRole) something;
        }
    }
}