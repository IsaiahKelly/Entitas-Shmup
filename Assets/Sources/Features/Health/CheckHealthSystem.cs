using System.Collections.Generic;
using Entitas;

//public sealed class CheckHealthSystem : ISetPools, IEntityCollectorSystem {
public sealed class CheckHealthSystem {

    public Collector entityCollector { get { return _groupObserver; } }

    Collector _groupObserver;

    //public void SetPools(Contexts contexts) {
    //    _groupObserver = new[] { contexts.core, contexts.bullets }
    //        .CreateEntityCollector(CoreMatcher.Health);
    //}


    public void Execute(List<Entity> entities) {
        foreach(var e in entities) {
            if(e.health.value <= 0) {
                e.flagDestroy = true;
            }
        }
    }
}
