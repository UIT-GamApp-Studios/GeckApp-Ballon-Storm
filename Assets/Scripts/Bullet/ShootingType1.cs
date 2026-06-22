using System.Collections;
using UnityEngine;

public class ShootingType1 : BaseShootingType
{
    public override IEnumerator Shoot()
    {
        for (int i = 1; i <= 3; i++)
        {
            Instantiate(Bullet, HeadGun.transform.position, transform.rotation);
            yield return new WaitForSeconds(0.15f);
        }
    }
}
