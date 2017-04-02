using System.Collections.Generic;
using Entitas;

//public sealed class DestroyEntitySystem : ISetPools, IEntityCollectorSystem {
public sealed class DestroyEntitySystem {

    public Collector entityCollector { get { return _groupObserver; } }

    Context[] _contexts;
    Collector _groupObserver;

    //public void SetPools(Contexts contexts) {
    //    _contexts = new[] { contexts.core, contexts.bullets };
    //    _groupObserver = _contexts.CreateEntityCollector(Matcher.AnyOf(CoreMatcher.Destroy, CoreMatcher.OutOfScreen));
    //}

    public void Execute(List<Entity> entities) {
        foreach(var e in entities) {
            foreach(var context in _contexts) {
                if(context.HasEntity(e)) {
                    context.DestroyEntity(e);
                    break;
                }
            }
        }
    }
}
