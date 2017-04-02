using Entitas;

public static class TestHelper {

    public static Context CreateCorePool() {
        //return new Context(CoreComponentIds.TotalComponents, 0, new PoolMetaData("Core Context", CoreComponentIds.componentNames, CoreComponentIds.componentTypes));
        return null;
    }

    public static Context CreateInputPool() {
        //return new Context(InputComponentIds.TotalComponents, 0, new PoolMetaData("Input Context", InputComponentIds.componentNames, InputComponentIds.componentTypes));
        return null;
    }

    public static Context CreateBulletsPool() {
        //return new Context(BulletsComponentIds.TotalComponents, 0, new PoolMetaData("Bullets Context", BulletsComponentIds.componentNames, BulletsComponentIds.componentTypes));
        return null;
    }
}

