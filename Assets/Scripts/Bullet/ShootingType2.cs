using System.Collections;
using UnityEngine;

public class ShootingType2 : BaseShootingType
{
    [SerializeField] private GameObject HeadGun1;
    [SerializeField] private GameObject HeadGun2;
    public override IEnumerator Shoot()
    {
        Instantiate(Bullet, HeadGun.transform.position, transform.rotation);
        Instantiate(Bullet, HeadGun1.transform.position, transform.rotation);
        Instantiate(Bullet, HeadGun2.transform.position, transform.rotation);
        yield return null;
    }
}
