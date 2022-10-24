using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaku : MonoBehaviour
{
    public static zaku instance;

    private void Awake()
    {
        instance = this;
    }


    [SerializeField]
    public Renderer zaku1;//Renderer型の変数aを宣言　好きなゲームオブジェクトをアタッチ
    

    void Start()
    {
        zaku1.enabled = false;
        

    }

    public void soundZaku()
    {
        zaku1.enabled = true;
        
    }

    public void notsoundZaku()
    {
        zaku1.enabled = false;
        
    }
}
