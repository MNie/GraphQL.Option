namespace GraphQL.Option
{
    using global::Option;

    using GraphQL.Types;

    public class NoneGraphType<TValue> : ObjectGraphType<Option<TValue>>
    {
        public NoneGraphType()
        {
            this.Name = "None";
            this.Field<NonNullGraphType<BooleanGraphType>>("isNone", resolve: ctx => ctx.Source.IsNone);
        }
    }
}