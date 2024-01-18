using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public GameObject toothless;
    public bool isMoving = false;
    public Auto auto;

    // Start is called before the first frame update
    void Start()
    {
        toothless.GetComponent<Animator>().enabled = isMoving;
        auto = FindAnyObjectByType<Auto>();
    }

    // Update is called once per frame
    void Update()
    {
        if (auto.autoClick > 0)
        {
            toothless.GetComponent<Animator>().enabled = true;
            toothless.GetComponent<Animator>().speed = 1 * (0.25f * auto.autoClick);
        }
    }
}
