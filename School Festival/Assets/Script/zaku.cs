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
    public Renderer zaku1;//Renderer�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`
    

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
