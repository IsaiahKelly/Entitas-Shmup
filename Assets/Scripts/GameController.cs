using Entitas;
using Entitas.Unity.Serialization.Blueprints;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Blueprints blueprints;

    Systems _systems;

    void Awake() {
        Application.targetFrameRate = 60;
    }

    void Start() {
        GameRandom.core = new Rand(0);
        GameRandom.view = new Rand(0);

        var contexts = Contexts.sharedInstance;
        contexts.SetAllContexts();
        contexts.AddEntityIndices();

        contexts.blueprints.SetBlueprints(blueprints);

        _systems = createSystems(contexts);

        // Suggested systems lifecycle:
        // systems.Initialize() on Start
        // systems.Execute() on Update
        // systems.Cleanup() on Update after systems.Execute()
        // systems.TearDown() on OnDestroy

        _systems.Initialize();
    }

    void Update() {
        _systems.Execute();
        _systems.Cleanup();
    }

    void OnDestroy() {
        _systems.TearDown();
    }

    Systems createSystems(Contexts contexts) {
        return null;
        //return new Feature("Systems")

            // // Initialize
            //.Add(contexts.CreateSystem(new IncrementTickSystem()))
            //.Add(contexts.CreateSystem(new CreatePlayerSystem()))
            //.Add(contexts.CreateSystem(new CreateEnemySystem()))

            //.Add(contexts.core.CreateSystem(new AddViewSystem()))
            //.Add(contexts.bullets.CreateSystem(new AddViewFromObjectcontextsystem()))

            // // Input
            //.Add(contexts.CreateSystem(new InputSystem()))
            //.Add(contexts.input.CreateSystem(new ProcessMoveInputSystem()))
            //.Add(contexts.input.CreateSystem(new ProcessShootInputSystem()))
            //.Add(contexts.input.CreateSystem(new ProcessCollisionSystem()))
            //.Add(contexts.input.CreateSystem(new SlowMotionSystem()))

            // // Update
            //.Add(contexts.core.CreateSystem(new BulletCoolDownSystem()))
            //.Add(contexts.core.CreateSystem(new StartEnemyWaveSystem()))
            //.Add(contexts.CreateSystem(new VelocitySystem()))
            //.Add(contexts.CreateSystem(new RenderPositionSystem()))
            //.Add(contexts.core.CreateSystem(new CheckHealthSystem()))
            //.Add(contexts.bullets.CreateSystem(new BulletOutOfScreenSystem()))

            // // Animate Destroy
            //.Add(contexts.CreateSystem(new AnimateOutOfScreenViewSystem()))
            //.Add(contexts.CreateSystem(new AnimateDestroyViewSystem()))

            // // Destroy
            //.Add(contexts.CreateSystem(new DestroyEntitySystem()));
    }
}
