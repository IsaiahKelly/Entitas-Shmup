using System;
using System.Collections.Generic;
using Entitas;

//public sealed class ProcessCollisionSystem : ISetPool, IReactiveSystem, ICleanupSystem {
public sealed class ProcessCollisionSystem : ICleanupSystem { // ReactiveSystem,

    //public TriggerOnEvent trigger { get { return InputMatcher.Collision.Added(); } }

    Context _context;
    Group _collisions;

    //void ISetPool.SetPool(Context context) {
    //    _context = context;
    //    _collisions = context.GetGroup(InputMatcher.Collision);
    //}

    //public void Execute(List<Entity> entities) {
    //    foreach(var e in entities) {
    //        e.collision.self.ReplaceHealth(e.collision.self.health.value - 1);
    //        var newHealth = e.collision.other.health.value - e.collision.self.damage.value;
    //        e.collision.other.ReplaceHealth(Math.Max(0, newHealth));
    //    }
    //}

    public void Cleanup()
    {
        foreach (var e in _collisions.GetEntities())
        {
            _context.DestroyEntity(e);
        }
    }

    //protected override Collector GetTrigger(Context context)
    //{
    //    throw new NotImplementedException();
    //}

    //protected override bool Filter(Entity entity)
    //{
    //    throw new NotImplementedException();
    //}

    //protected override void Execute(List<Entity> entities) {
    //    foreach(var e in entities) {
    //        e.collision.self.ReplaceHealth(e.collision.self.health.value - 1);
    //        var newHealth = e.collision.other.health.value - e.collision.self.damage.value;
    //        e.collision.other.ReplaceHealth(Math.Max(0, newHealth));
    //    }
    //}
}
