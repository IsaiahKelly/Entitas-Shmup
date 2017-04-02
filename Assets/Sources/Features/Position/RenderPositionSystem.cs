using System.Collections.Generic;
using Entitas;

//public sealed class RenderPositionSystem : ISetPools, IEntityCollectorSystem {
public sealed class RenderPositionSystem {
    public Collector entityCollector { get { return _groupObserver; } }

    Collector _groupObserver;

    //public void SetPools(Contexts contexts) {
    //    _groupObserver = new [] { contexts.core, contexts.bullets }
    //        .CreateEntityCollector(Matcher.AllOf(CoreMatcher.View, CoreMatcher.Position));
    //}

    public void Execute(List<Entity> entities) {
        foreach(var e in entities) {
            e.view.controller.position = e.position.value;
        }
    }
}
