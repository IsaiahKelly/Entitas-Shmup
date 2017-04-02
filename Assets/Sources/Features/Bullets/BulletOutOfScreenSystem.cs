﻿using Entitas;

//public sealed class BulletOutOfScreenSystem : ISetPools, IExecuteSystem {
public sealed class BulletOutOfScreenSystem : IExecuteSystem {
    Group _bullets;

    //public void SetPools(Contexts contexts) {
    //    _bullets = contexts.bullets.GetGroup(Matcher.AllOf(BulletsMatcher.Bullet, BulletsMatcher.Position));
    //}

    public void Execute() {
        foreach(var e in _bullets.GetEntities()) {

            // TODO Define OutOfScreen Y position
            // TODO When OutOfScreen at the bottom

            if(e.position.value.y > 20f) {
                e.isOutOfScreen = true;
            }
        }
    }
}
