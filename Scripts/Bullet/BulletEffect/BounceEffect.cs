using UnityEngine;

public class BounceEffect : BulletEffect {

    public int bounceCounter;
    public int numberOfBounce;

    public override void Effect(EffectSource source) {
        if (numberOfBounce == bounceCounter)
            GetComponent<Bullet>().OnDestroy();
        if ((hit.collider.gameObject.layer == LayerMask.NameToLayer("Indestructible"))
            || (hit.collider.gameObject.layer == LayerMask.NameToLayer("Destructible"))) {
            numberOfBounce++;
            transform.Rotate(Vector3.up, 180 + 2 * Vector3.Angle(transform.forward, hit.normal));
        }

        if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Bullet")) {
            GetComponent<Bullet>().OnDestroy();
        }

    }

}
