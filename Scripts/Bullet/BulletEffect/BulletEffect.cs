using UnityEngine;
using System.Collections;

public enum EffectSource { Collision, Timer, Creation, Destruction }

public abstract class BulletEffect : MonoBehaviour {

    public bool applyOnCollision;

    public bool applyOnTimer;
    public float timer;

    public bool applyOnCreation;
    
    public bool applyOnDestruction;

    protected RaycastHit hit;
    protected bool hitting;
    protected float elapsedTime;

    public void OnObstacleCollision(RaycastHit hit) {
        if (applyOnCollision) {
            this.hit = hit;
            hitting = true;
            Effect(EffectSource.Collision);
            hitting = false;
        }
    }

    public void OnRefreshTimer() {
        if (applyOnTimer) {
            elapsedTime += Time.deltaTime;
            if( timer <= elapsedTime) {
                Effect(EffectSource.Timer);
                elapsedTime = 0f;
            }
        }
    }

    public void OnCreation() {
        if (applyOnCreation) {
            Effect(EffectSource.Creation);
        }
    }

    public void OnDestruction() {
        if (applyOnDestruction) {
            Effect(EffectSource.Destruction);
        }
    }

    public abstract void Effect(EffectSource source);
}
