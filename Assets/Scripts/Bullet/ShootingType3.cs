using System.Collections;
using UnityEngine;

public class ShootingType3 : BaseShootingType
{
    public override IEnumerator Shoot()
    {
        for (int i = 1; i <= 3; i++)
        {
            Instantiate(Bullet, HeadGun.transform.position, transform.rotation * Quaternion.Euler(0, 0, i * 30f - 60f));
        }
        yield return null;
    }
}
