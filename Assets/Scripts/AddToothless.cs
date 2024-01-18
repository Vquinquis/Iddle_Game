using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToothless : MonoBehaviour
{
    public Animate animate;
    public GameObject prefabToothless;
    public ScoreManager scoreManager;
    public Click click;
    public Auto auto;
    public int price = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        animate = FindAnyObjectByType<Animate>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
        click = FindAnyObjectByType<Click>();
        auto = FindAnyObjectByType<Auto>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (scoreManager.score >= price)
        {
            transform.localScale = new Vector2(0.28f, 0.28f);
            scoreManager.score -= price;
            price += 50;
            scoreManager.nbToothless += 1;
            GameObject newToothless = Instantiate(prefabToothless);
            newToothless.transform.position = new Vector3(Random.Range(-12.36f, 12.55f), Random.Range(-3.48f, -1.7f), 0);
            newToothless.GetComponent<Animator>().enabled = false;
            animate.toothless = newToothless;
            auto.autoClick = 0;
            click.toothless = newToothless;
        }
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector2(0.4f, 0.4f);
    }
}
