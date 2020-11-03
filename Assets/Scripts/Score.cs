using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public bool good;

    // Start is called before the first frame update
    void Start()
    {
        if (good)
        { 
            LeanTween.moveX(gameObject, -30, 4f);
            LeanTween.scale(gameObject, new Vector3(0.1f, 0.1f, 0.1f), 2f);
        }
        else
        {
            LeanTween.moveX(gameObject, 30, 4f);
            LeanTween.scale(gameObject, new Vector3(0.1f, 0.1f, 0.1f), 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
