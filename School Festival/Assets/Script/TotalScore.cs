using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Nissensai2022.Runtime;


public class TotalScore : MonoBehaviour
{
    public Text scoreText;
    public Text mathText;
    public static ResultRank rank = ResultRank.E;
    
    int score;
    
    // Start is called before the first frame update
    void Start()
    {
        // Invoke("sprite", 2);

        rank = ResultRank.E;
        score = Timer.getscore();
        //Debug.Log(score);

        mathText.text ="" + score;

        if (score > 8000)

            rank = ResultRank.A;



        else if (score > 6000)

            rank = ResultRank.B;


        else if (score > 4000)

            rank = ResultRank.C;


        else if (score > 2000)

            rank = ResultRank.D;


        else if (score > 0)
        
            rank = ResultRank.E;
            
        

        scoreText.text = "Result" + rank;
    }
    void Sprite()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Nissensai.SendResult(rank);
        }


    }





}



