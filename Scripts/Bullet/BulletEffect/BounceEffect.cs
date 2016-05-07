using UnityEngine;

public class BounceEffect : BulletEffect {

    public int bounceCounter;
    public int numberOfBounce;

    public override void Effect(EffectSource source) {
        if (numberOfBounce >= bounceCounter) {
            GetComponent<Bullet>().OnDestroy();
        }
        if ((hit.collider.gameObject.layer == LayerMask.NameToLayer("Indestructible")) 
            || (hit.collider.gameObject.layer == LayerMask.NameToLayer("Destructible"))) {
            numberOfBounce++;
            transform.forward = Vector3.Reflect(transform.forward, hit.normal);
        }
    }
    
}
