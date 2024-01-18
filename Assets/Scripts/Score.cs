using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI toothlessText;
    public TextMeshProUGUI autoText;
    public TextMeshProUGUI priceFish;
    public TextMeshProUGUI priceAdd;
    public Auto auto;
    public AddToothless add;
    public int nbToothless = 0;
    public int nbAuto = 0;
    // Start is called before the first frame update
    void Start()
    {
        auto = FindAnyObjectByType<Auto>();
        add = FindAnyObjectByType<AddToothless>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate();
    }

    public void RiseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString("0000$");
    }
    public void ScoreUpdate()
    {
        toothlessText.text = nbToothless.ToString("0");
        autoText.text = nbAuto.ToString("+" + "0");
        scoreText.text = score.ToString("0000$");
        priceAdd.text = add.price.ToString("000$");
        priceFish.text = auto.price.ToString("00$");
    }
}