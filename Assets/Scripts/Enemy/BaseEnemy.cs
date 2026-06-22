using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [SerializeField] private float EnemySpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    virtual public void Move()
    {
        
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
