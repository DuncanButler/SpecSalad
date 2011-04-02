using FakeItEasy;
using Machine.Specifications;

namespace SpecSalad.Specifications
{
    [Subject("Actor")]
    public class the_actor_should : ActorContext
    {
        Establish context =
            () =>
                {
                    _role_description = "Butler";                 

                    A.CallTo(() => _director.How_Do_I_Perform(_role_description)).Returns(new Butler());                    
                };

        Because of =
            () =>
                {
                    _actor = new Actor(_role_description, _director);
                };

        It get_into_the_character =
            () => A.CallTo(() => _director.How_Do_I_Perform(_role_description)).MustHaveHappened();
    }

    [Subject("Actor")]
    public class performs_a_simple_task_as_the_character : ActorContext
    {
        Establish context =
            () =>
                {
                    _role_description = "Butler";
                    _task_description = "set the place at the table";

                    A.CallTo(() => _director.How_Do_I_Perform(_role_description)).Returns(new Butler());
                    A.CallTo(() => _director.How_Do_I_Perform(_task_description)).Returns(new SetThePlaceAtTheTable());

                    _actor = new Actor(_role_description,_director);
                };

        Because of =
            () =>
                {
                    _result = _actor.Answer(_task_description);
                };

        It calls_the_director_to_get_task =
            () => A.CallTo(() =>_director.How_Do_I_Perform(_task_description)).MustHaveHappened();
	
        It and_gets_the_correct_result =
            () => _result.ShouldEqual(new[] {"fork", "knife"});        
    }

    [Subject("Actor")]
    public class performs_a_simple_task_as_a_character_that_requires_details : ActorContext
    {
        Establish context =
            () =>
                {
                    _role_description = "Butler";
                    _task_description = "Lay the Table";
                    _details = "with places for '5'";

                    A.CallTo(() => _director.How_Do_I_Perform(_role_description)).Returns(new Butler());
                    A.CallTo(() => _director.How_Do_I_Perform(_task_description)).Returns(new LayTheTable());

                    _actor = new Actor(_role_description,_director);
                };

        Because of =
            () =>
                {
                    _result = _actor.Answer(_task_description, _details);
                };

        It gets_the_correct_result =
            () => _result.ShouldEqual(5);	
    }

    public class ActorContext
    {
        Establish context =
            () =>
                {                    
                    _director = A.Fake<Director>();
                };

        protected static Director _director;
        protected static string _role_description;
        protected static Actor _actor;
        protected static string _task_description;
        protected static object _result;
        protected static string _details;
    }
}