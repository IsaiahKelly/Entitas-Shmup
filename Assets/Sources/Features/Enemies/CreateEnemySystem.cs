using Entitas;

//public sealed class CreateEnemySystem : ISetPools, IExecuteSystem {
public sealed class CreateEnemySystem : IExecuteSystem {

    Contexts _contexts;

    public void SetPools(Contexts contexts) {
        _contexts = contexts;
    }

    public void Execute() {

        // TODO Interval should be configurable
        if(_contexts.input.tick.value % 60 == 0) {
            _contexts.blueprints.blueprints.instance
                  .ApplyEnemy(_contexts.core.CreateEntity());
        }
    }
}
