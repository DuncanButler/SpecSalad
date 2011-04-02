using System;
using Machine.Specifications;

namespace SpecSalad.Specifications
{
    [Subject("Director")]
    public class returns_the_classe_instances : DirectorContext
    {
        It for_a_directive_for_something =
            () => _director.How_Do_I_Perform("Something").ShouldBeOfType<Something>();

        It for_a_directive_for_something_described_wtih_more_than_one_word =
            () => _director.How_Do_I_Perform("more than one word").ShouldBeOfType<MoreThanOneWord>();

        It throws_exception_when_item_cannot_be_found =
            () =>
            Catch.Exception(() => _director.How_Do_I_Perform("something that is not there")).ShouldBeOfType<ArgumentException>();

        It exception_thrown_has_expected_message =
            () => Catch.Exception(() => _director.How_Do_I_Perform("Something that is not there")).Message.ShouldEqual
                      ("You need to define the role or task 'Something that is not there'");	
    }

    public class DirectorContext
    {
        Establish context =
            () =>
                {
                    _director = new SaladDirector();
                };

        protected static SaladDirector _director;
    }
}