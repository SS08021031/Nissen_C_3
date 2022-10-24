using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GergeCon : MonoBehaviour
{
    public Image Gauge1;
    public Image Gauge2;
    public float gaugeime = 30;

    public float timeOut = 30f;
    private float timeElapsed;



    void Start()
    {
        Gauge1.fillAmount = 1;
        Gauge2.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Gauge1.fillAmount -= 0.0045f / gaugeime;
        Gauge2.fillAmount += 0.0045f / gaugeime;

        timeElapsed += Time.deltaTime;
        Debug.Log(timeElapsed);
        if (timeElapsed >= timeOut)
        {
            timeElapsed = 0;
            Gauge1.fillAmount = 0;
            Gauge2.fillAmount = 1;
            SceneManager.LoadScene("result");
        }
     
    }
}
