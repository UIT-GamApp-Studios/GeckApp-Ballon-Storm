using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    [SerializeField] private float ScrollingSpeed;
    [SerializeField] private GameObject[] Backgrounds;
    [SerializeField] private float ScrollingDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        foreach (var background in Backgrounds)
        {
            if (background.transform.position.x <= -ScrollingDistance)
            {
                background.transform.position += new Vector3(Backgrounds.Length * ScrollingDistance, 0, 0);
            }
            background.transform.position += new Vector3(-ScrollingSpeed * Time.deltaTime, 0, 0);
        }
    }
}
