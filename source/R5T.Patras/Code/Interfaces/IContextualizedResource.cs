using System;


namespace R5T.Patras
{
    public interface IContextualizedResource<TResource, TContext>
    {
        TResource Resource { get; }


        IContextualizedResource<TResource, TNewContext> ChangeContext<TNewContext>();
    }
}
