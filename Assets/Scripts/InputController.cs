using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour
{

    public UnityEvent MoveNext;
    public UnityEvent MovePrev;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }


    void Inputs()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            MovePrev.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveNext.Invoke();
        }

    }
}
