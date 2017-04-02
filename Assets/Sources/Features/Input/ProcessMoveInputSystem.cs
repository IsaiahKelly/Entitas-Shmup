using Entitas;
using System.Collections.Generic;
using System;

//public sealed class ProcessMoveInputSystem : ISetPools, IReactiveSystem {
public sealed class ProcessMoveInputSystem {//: ReactiveSystem {

    //public TriggerOnEvent trigger { get { return InputMatcher.MoveInput.Added(); } }


    Contexts _pools;

    public void SetPools(Contexts contexts) {
        _pools = contexts;
    }

    //public void Execute(List<Entity> entities) {
    //    var input = entities[entities.Count - 1];
    //    var ownerId = input.inputOwner.playerId;

    //    var e = _pools.core.GetEntityWithPlayerId(ownerId);

    //    // TODO Speed Shoud be configurable
    //    e.ReplaceVelocity(input.moveInput.direction.normalized * 0.3f);
    //}

    //protected override Collector GetTrigger(Context context)
    //{
    //    throw new NotImplementedException();
    //}

    //protected override bool Filter(Entity entity)
    //{
    //    throw new NotImplementedException();
    //}

    //protected override void Execute(List<Entity> entities)
    //{
    //    var input = entities[entities.Count - 1];
    //    var ownerId = input.inputOwner.playerId;

    //    var e = _pools.core.GetEntityWithPlayerId(ownerId);

    //    TODO Speed Shoud be configurable
    //    e.ReplaceVelocity(input.moveInput.direction.normalized * 0.3f);
    //}
}
