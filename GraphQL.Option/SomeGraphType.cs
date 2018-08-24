namespace GraphQL.Option
{
    using global::Option;

    using GraphQL.Types;

    public class SomeGraphType<TType, TValue> : ObjectGraphType<Option<TValue>>
        where TType : GraphType
    {
        public SomeGraphType()
        {
            this.Name = "Some";
            this.Field<NonNullGraphType<TType>>("value", resolve: ctx => ctx.Source.Value);
            this.Field<NonNullGraphType<BooleanGraphType>>("isSome", resolve: ctx => ctx.Source.IsSome);
        }
    }
}