using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    public ScoreManager myScoreManager;
    public int autoClick=0;
    public int autoClickTotal = 0;
    public int price = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        myScoreManager = FindObjectOfType<ScoreManager>();


    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnMouseDown()
    {   
        if (myScoreManager.score >= price)
        {
            transform.localScale = new Vector2(0.7f, 0.7f);
            myScoreManager.score -= price;
            price += 10;
            myScoreManager.nbAuto += 1;
            autoClick += 1;
            autoClickTotal += 1;

        }
        
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(1, 1);
    }
}
