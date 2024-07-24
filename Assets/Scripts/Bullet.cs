using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject impactEffect;
    private void OnCollisionEnter(Collision collision)
    {
        CreateImpactEffect(collision);
        //collision.gameObject.GetComponent<TargetHealth>()?.TakeDamage(1);
        //ObjectPool.instance.ReturnBullet(gameObject);
        //ObjectPool.instance.ReturnObject(gameObject);
    }

    private void CreateImpactEffect(Collision collision)
    {
        if (collision.contacts.Length > 0)
        {
            ContactPoint contactPoint = collision.contacts[0];
            //GameObject impact = ObjectPool.instance.GetObject(impactEffect);
            impactEffect.transform.position = contactPoint.point;
            impactEffect.transform.rotation = Quaternion.LookRotation(contactPoint.normal);
            //ObjectPool.instance.ReturnObject(impact, 0.5f);
        }
    }
}
