using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pakupaku : MonoBehaviour
{
    public static pakupaku instance;

    private void Awake()
    {
        instance = this;
    }


    [SerializeField] 
    public Renderer paku1;//Renderer�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`
    public Renderer paku2;

    void Start()
    {
        paku1.enabled = false;
        paku2.enabled = false;
    }

    public void soundEat()
    {
        paku1.enabled = true;
        paku2.enabled = true;

    }

    public void notsoundEat()
    {
        paku1.enabled = false;
        paku2.enabled = false;
    }
}

