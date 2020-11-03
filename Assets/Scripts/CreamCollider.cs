using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamCollider : MonoBehaviour
{
    Item_Color c;
    // Start is called before the first frame update
    void Start()
    {
        c = transform.parent.GetComponent<Cake>().Cake_color;
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Item i = col.gameObject.GetComponent<Item>();
        if (i != null)
        {
            i.Splash(col.transform.position,c);

        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
