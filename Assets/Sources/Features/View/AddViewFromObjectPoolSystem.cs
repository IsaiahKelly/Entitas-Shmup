using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

//public sealed class AddViewFromObjectPoolSystem : ISetPool, IInitializeSystem, IReactiveSystem, IEnsureComponents {
public sealed class AddViewFromObjectPoolSystem : IInitializeSystem { // ReactiveSystem,

    //public TriggerOnEvent trigger { get { return BulletsMatcher.ViewObjectPool.Added(); } }

    //public IMatcher ensureComponents { get { return BulletsMatcher.ViewObjectPool; } }

    Context _context;
    Transform _container;

    public void SetPool(Context context) {
        _context = context;
    }

    public void Initialize() {
        //_container = new GameObject(_context.metaData.poolName + " Views (Pooled)").transform;
    }

    //public void Execute(List<Entity> entities) {
    //    foreach(var e in entities) {
    //        var gameObject = e.viewObjectPool.context.Get();
    //        gameObject.SetActive(true);
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
    //        var gameObject = e.viewObjectPool.context.Get();
    //        gameObject.SetActive(true);
    //        gameObject.transform.SetParent(_container, false);
    //        gameObject.Link(e, _context);
    //        e.AddView(gameObject.GetComponent<IViewController>());
    //    }
    //}
}
