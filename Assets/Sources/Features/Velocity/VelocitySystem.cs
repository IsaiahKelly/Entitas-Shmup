using Entitas;

//public sealed class VelocitySystem : ISetPools, IExecuteSystem {
public sealed class VelocitySystem : IExecuteSystem {
    Group[] _movableGroups;

    //public void SetPools(Contexts contexts) {
    //    var matcher = Matcher.AllOf(CoreMatcher.Velocity, CoreMatcher.Position);
    //    _movableGroups = new[] {
    //        contexts.core.GetGroup(matcher),
    //        contexts.bullets.GetGroup(matcher)
    //    };
    //}

    public void Execute() {
        foreach(var group in _movableGroups) {
            foreach(var e in group.GetEntities()) {
                var pos = e.position.value;
                e.ReplacePosition(pos + e.velocity.value);
            }
        }
    }
}
