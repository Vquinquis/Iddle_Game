using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public ScoreManager myScoreManager;
    public GameObject toothless;
    public ListeSprite list;


    private void Start()
    {
        myScoreManager = FindObjectOfType<ScoreManager>();
        list = FindAnyObjectByType<ListeSprite>();
        
    }
    
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        myScoreManager.RiseScore(myScoreManager.nbAuto);
        transform.localScale = new Vector2(0.26f, 0.26f);
        Sprite currentSprite = toothless.GetComponent<SpriteRenderer>().sprite;
        int currentIndex;
        foreach(Sprite sprite in list.sp)
        {
            if (sprite == currentSprite)
            {
                currentIndex = list.sp.IndexOf(sprite);
                if (currentIndex > 221)
                {
                    currentSprite = list.sp[0];
                }
                else
                {
                    currentSprite = list.sp[currentIndex + 1];
                }
                break;
            }
        }
        toothless.GetComponent<SpriteRenderer>().sprite = currentSprite;
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector2(0.37f, 0.37f);
    }
}
