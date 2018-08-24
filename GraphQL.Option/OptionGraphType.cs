using System;

namespace GraphQL.Option
{
    using GraphQL.Types;

    public class OptionGraphType<TType, TValue> : UnionGraphType
        where TType : GraphType
    {
        public OptionGraphType()
        {
            this.AddPossibleType(new SomeGraphType<TType, TValue>());
            this.AddPossibleType(new NoneGraphType<TValue>());
        }
    }
}
