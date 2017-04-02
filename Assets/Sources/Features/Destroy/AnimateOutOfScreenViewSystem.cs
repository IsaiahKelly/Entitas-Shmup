using System.Collections.Generic;
using Entitas;

//public sealed class AnimateOutOfScreenViewSystem : ISetPools, IEntityCollectorSystem {
public sealed class AnimateOutOfScreenViewSystem {
    public Collector entityCollector { get { return _groupObserver; } }

    Collector _groupObserver;

    public void SetPools(Contexts contexts) {
        //_groupObserver = new [] { contexts.core, contexts.bullets }
            //.CreateEntityCollector(Matcher.AllOf(CoreMatcher.View, CoreMatcher.OutOfScreen));
    }

    public void Execute(List<Entity> entities) {
        foreach(var e in entities) {
            var controller = e.view.controller;
            controller.Hide(false);
        }
    }
}
