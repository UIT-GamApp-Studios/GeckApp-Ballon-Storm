using System.Collections;
using UnityEngine;

public class BaseShootingType : MonoBehaviour
{
    public int ShootingID;
    [SerializeField] protected BaseBullet Bullet;
    [SerializeField] protected GameObject HeadGun;
    virtual public IEnumerator Shoot()
    {
        yield return null;
    }
}
