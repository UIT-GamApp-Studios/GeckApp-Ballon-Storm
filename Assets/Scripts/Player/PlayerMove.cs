using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float PlayerSpeed;
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
        float x = 0f;
        float y = 0f;
        Keyboard currentKeyboard = Keyboard.current;
        if (currentKeyboard != null)
        {
            if (currentKeyboard.dKey.isPressed)
            {
                x = 1f;
            }
            else if (currentKeyboard.aKey.isPressed)
            {
                x = -1f;
            }
            if (currentKeyboard.wKey.isPressed)
            {
                y = 1f;
            }
            else if (currentKeyboard.sKey.isPressed)
            {
                y = -1f;
            }
        }
        float Angle_Direction = Mathf.Atan2(y, x) * Mathf.Rad2Deg; // Ham tinh goc quay. Atan2 tra ve radian, goc trong Unity dung don vi do
        Quaternion targetAngle = Quaternion.Euler(0, 0, Angle_Direction - 90f); // Goc thi phai setting lai tu dau
        transform.rotation = Quaternion.Slerp(transform.rotation, targetAngle, Time.deltaTime * PlayerSpeed);
        transform.position += new Vector3(x * PlayerSpeed * Time.deltaTime, y * PlayerSpeed * Time.deltaTime, 0);
    }
}
