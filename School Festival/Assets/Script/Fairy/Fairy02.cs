using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy02 : MonoBehaviour
{
    private Vector3 fairyPos;
    [SerializeField]
    float moveSpeed = 5f;
    public float A = 1000.0f;
    public float B = 0.5f;

    private void Start()
    {
        fairyPos = transform.position;
        Audio_Manager.instance.PlaySE(2);
    }
    private void Update()
    {
        fairyPos += transform.right * Time.deltaTime * moveSpeed;
        transform.position = fairyPos + transform.up * Mathf.Sin(Time.time * A) * B;
        //transform.position = new Vector3(Mathf.Sin(A * Time.time) * 100.0f + fairyPos.x, Mathf.Cos(B * Time.time) * 1.0f + fairyPos.y);

        if (transform.position.x >= 25.0f)
        {
            
            Debug.Log("kieru");
            Destroy(gameObject);
        }
    }

    

}
