using Entitas;

//public sealed class IncrementTickSystem : ISetPools, IInitializeSystem, IExecuteSystem {
public sealed class IncrementTickSystem : IInitializeSystem, IExecuteSystem {

    Contexts _contexts;

    //public void SetPools(Contexts contexts) {
    //    _contexts = contexts;
    //}

    public void Initialize() {
       _contexts.input.SetTick(0);
    }

    public void Execute() {
       _contexts.input.ReplaceTick(_contexts.input.tick.value + 1);
    }
}
