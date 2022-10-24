using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    
    public static int score;

    public static int getscore()
    {
        return score;
    }
    void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            score += 100;
        }
    }
}
