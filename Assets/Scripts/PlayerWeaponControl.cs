using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponControl : MonoBehaviour
{
    public void Shoot()
    {
        Debug.Log("Pew pew");
        //RaycastHit hitPoint = player.aim.GetHitPoint();
        //GameObject newBullet = ObjectPool.instance.GetObject(bulletPrefab);
        //newBullet.transform.position = firePos.position;
        //Vector3 bulletDirection = hitPoint.point - newBullet.transform.position;
        //Vector3 newDirection = currentWeapon.ApplySpread(bulletDirection);
        //newBullet.GetComponent<Rigidbody>().velocity = newDirection * bulletSpeed;
    }
}
