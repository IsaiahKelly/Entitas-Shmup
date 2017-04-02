using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

//public sealed class AddViewSystem : ISetPool, IInitializeSystem, IReactiveSystem {
public sealed class AddViewSystem {//: ReactiveSystem, IInitializeSystem {

    //public TriggerOnEvent trigger { get { return CoreMatcher.Asset.Added(); } }

    Context _context;
    Transform _container;

    public void SetPool(Context context) {
        _context = context;
    }

    public void Initialize() {
        //_container = new GameObject(_context.metaData.poolName + " Views").transform;
    }

    //public void Execute(List<Entity> entities) {
    //    foreach(var e in entities) {
    //        var gameObject = Assets.Instantiate<GameObject>(e.asset.name);
    //        gameObject.transform.SetParent(_container, false);
    //        gameObject.Link(e, _context);
    //        e.AddView(gameObject.GetComponent<IViewController>());
    //    }
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
    //    foreach (var e in entities)
    //    {
    //        var gameObject = Assets.Instantiate<GameObject>(e.asset.name);
    //        gameObject.transform.SetParent(_container, false);
    //        gameObject.Link(e, _context);
    //        e.AddView(gameObject.GetComponent<IViewController>());
    //    }
    //}
}
