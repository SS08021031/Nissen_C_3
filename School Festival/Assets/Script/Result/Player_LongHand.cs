using UnityEngine;

public class Player_LongHand : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform target2;

    public float targetX;
    public float targetY;

    public float target2X;
    public float target2Y;

    public bool targetCheck;

    public GameObject fukuro;

    void Start()
    {
        target.transform.position = new Vector2(targetX, targetY);

        targetCheck = false;
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);

        Invoke("Check", 3);

        if(targetCheck == true)
        {
            target.transform.position = new Vector2(target2X, target2Y);

            speed = 0.1f;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
            targetCheck = true;

            fukuro.gameObject.transform.parent = null;
        }
    }

    void Check()
    {
        targetCheck = true;
    }
}
