using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy03 : MonoBehaviour
{
    public float speed = 10f;
    
    public bool isReturn;
    
    // Start is called before the first frame update
    void Start()
    {
        isReturn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReturn == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

            if (transform.position.x >= 12.0f)
            {
                isReturn = true;
            }
        }

        if(isReturn == true)
        {
            //transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
            GameObject child = transform.GetChild(0).gameObject;
            child.transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }



            if (transform.position.x <= -30.0f)
        {
            Destroy(gameObject);
        }
    }
}
