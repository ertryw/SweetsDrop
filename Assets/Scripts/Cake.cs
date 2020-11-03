using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public float speed = 1f;
    public bool move = false;
    public Item_Color Cake_color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void canMove()
    {
        move = false;
    }
    public void MoveNext()
    {
        if (move == true)
            return;

        move = true;
        transform.LeanMoveX(transform.position.x + 25, speed).setOnComplete(canMove);
    }

    public void MovePrevious()
    {
        if (move == true)
            return;

        move = true;
        transform.LeanMoveX(transform.position.x - 25, speed).setOnComplete(canMove); ;
    }


    public void MoveCenter()
    {
        if (move == true)
            return;

        move = true;
        transform.LeanMoveX(-0.5f, speed).setOnComplete(canMove); ;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= 100)
        {
            transform.position = new Vector3(-25f, transform.position.y, 0);
        }

        if (transform.position.x <= -50)
        {
            transform.position = new Vector3(75f, transform.position.y, 0);
        }

    }
}
