using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food01 : MonoBehaviour
{
    
    public int FoodScore;
    public bool isEat;

    
    



    void Start()
    {
        isEat = false;
       
    }
    void Update()
    {

        if (isEat == false)
        {
            if (transform.position.y >= 0.4f)
            {
                
                isEat = true;

                Eat();
                
            }
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fork"))
        {
            zaku.instance.soundZaku();
            Audio_Manager.instance.PlaySE(7);
            this.gameObject.transform.parent = other.gameObject.transform;
        }
           
    }
    
    void Eat()
    {
        zaku.instance.notsoundZaku();
        pakupaku.instance.soundEat();
        Invoke("Destroy", 1);
        
        
    }
    void Destroy()
    {
        
        Destroy(gameObject);
        Audio_Manager.instance.PlaySE(1);
        Timer.score += FoodScore;
        mouth.instance.Eatanim();
        pakupaku.instance.notsoundEat();
    }
}
