using Entitas;

public static class EntityIndexPoolsExtensions {

    public const string PlayerKey = "Player";

    public static void AddEntityIndices(this Contexts contexts) {
        //var playerIndex = new PrimaryEntityIndex<string>(
            //contexts.core.GetGroup(CoreMatcher.Player),
            //(entity, component) => {
            //    var playerComponent = (PlayerComponent)component;
            //    return playerComponent != null
            //        ? playerComponent.id
            //        : entity.player.id;
            
        //);

        //contexts.core.AddEntityIndex(PlayerKey, playerIndex);
    }

//public static Entity GetEntityWithPlayerId(this Context context, string id)
//{
//    var index = (PrimaryEntityIndex<string>)context.GetEntityIndex(PlayerKey);
//    return index.GetEntity(id);
//    return null;
//}
}
