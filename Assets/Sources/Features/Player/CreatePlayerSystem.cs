using Entitas;
using UnityEngine;

//public sealed class CreatePlayerSystem : ISetPools, IInitializeSystem {
public sealed class CreatePlayerSystem : IInitializeSystem {
    Contexts _context;

    //public void SetPools(Contexts contexts) {
    //    _context = contexts;
    //}

    public void Initialize() {
        _context.blueprints.blueprints.instance
              .ApplyPlayer1(_context.core.CreateEntity(), Vector3.zero);
    }
}
