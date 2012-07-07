using Machine.Specifications;

namespace SpecSalad.Specifications
{
    [Subject("Needing Specifics")]
    public class splitting_single_key_value_pair : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("specific 'information'");
                };

        It has_an_item_of_specific_information =
            () => _specifics.Value_Of("specific").ShouldEqual("information");	
    }

    [Subject("Needing Specifics")]
    public class splitting_more_than_one_key_value_pair : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("first 'item' second 'another'");
                };

        It first_pair_has_correct_value =
            () => _specifics.Value_Of("first").ShouldEqual("item");

        It second_pair_has_correct_value =
            () => _specifics.Value_Of("second").ShouldEqual("another");	
    }

    [Subject("Needing Specifics")]
    public class splitting_with_multiple_words_in_key : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("first thing 'item' second thing 'another'");
                };

        It first_pair_has_correct_value =
            () => _specifics.Value_Of("first_thing").ShouldEqual("item");

        It second_pair_has_correct_value =
            () => _specifics.Value_Of("second_thing").ShouldEqual("another");
	
    }

    [Subject("Needing Specifics")]
    public class splitting_with_muliple_words_in_value : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("first thing 'item' second thing 'another thing'");
                };

        It first_pair_has_correct_value =
            () => _specifics.Value_Of("first_thing").ShouldEqual("item");

        It second_pair_has_correct_value =
            () => _specifics.Value_Of("second_thing").ShouldEqual("another thing");	
    }

    [Subject("Needing Specifics")]
    public class calling_value_with_no_details_set : NeedingSpecificsContext
    {
        Because of =
            () =>
                {
                    _result = _specifics.Value();
                };

        It returns_an_empty_string =
            () => _result.ShouldBeEmpty();

        static string _result;
    }

    [Subject("Needing Specifics")]
    public class calling_value_with_a_single_detail_set : NeedingSpecificsContext
    {
        Establish context =
            () => _specifics.Understand_The("first thing 'first' second thing 'second'");

        Because of =
            () =>
                {
                    _result = _specifics.Value();
                };

        It returns_the_set_value =
            () => _result.ShouldEqual("first");

        static string _result;
    }

    [Subject("Needing Specifics")]
    public class calling_value_with_multiple_details_set : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("first");
                };

        Because of =
            () =>
                {
                    _result = _specifics.Value();
                };

        It returns_the_first_value =
            () => _result.ShouldEqual("first");

        static string _result;
    }

    [Subject("Needing Specifics")]
    public class can_get_key_names_by_index_and_a_count_items : NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics.Understand_The("first 'value 1' second 'value 2'");
                };

        It returns_the_first_key =
            () => _specifics.Key(0).ShouldEqual("first");

        It returns_the_second_key =
            () => _specifics.Key(1).ShouldEqual("second");

        It returns_the_count_two =
            () => _specifics.Count();
    }

    public class NeedingSpecificsContext
    {
        Establish context =
            () =>
                {
                    _specifics = new NeedingSpecifics();
                };

        protected static NeedingSpecifics _specifics;
    }
}
