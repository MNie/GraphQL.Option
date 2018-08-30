# GraphQL.Option

Simple implementation of an OptionType in GraphQL. Thanks to which you could express an `option` known from for example F# in your graph.

Usage looks like this:

```csharp
class A : ObjectGraphType<ASource>
{
  ...
  public A()
  {
    ...
    Field<NonNullGraphType<OptionGraphType<IntGraphType, int>>>("fieldA", resolve: ctx => ctx.Source.fieldA)
    ...
  }
  ...
}
```

```graphql
A {
  fieldA {
    _typename
    ... on Some { value isSome }
    ... on None { isNone }
  }
}
```

and response could look like this:

```graphql
{
  "data": {
    "A": {
      "fieldA": {
        "__typename": "Some",
        "value": 44,
        "isSome": true
      }
    }
  }
}
```
