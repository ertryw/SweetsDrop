using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // 0 1 2
    //public GameObject[] Cakes;
    public bool CanGame = true;
    public Cake[] Cakes;


    public FloatReference Scores;
    public FloatReference HightScores;
    public FloatReference Fails;
    public FloatReference HightFails;


    public ItemSpawner iSpawner;
    public GameObject panelEnd;

    // Start is called before the first frame update
    void Start()
    {
        CanGame = true;
        Scores.Variable.Value = 0;
        Fails.Variable.Value = 0;
        HightScores.Variable.Value = PlayerPrefs.GetInt("HightScores");
    }

    public void AddScore()
    {
        Scores.Variable.Value++;
        iSpawner.spawnTime -= 0.01f;
    }

    public void gameExit()
    {
        Application.Quit();
    }
    public void AddFailsScore()
    {
        Fails.Variable.Value++;
        iSpawner.spawnTime -= 0.01f;
    }

    public void ShitRight()
    {

        if (Cakes[0].move || Cakes[1].move || Cakes[2].move || Cakes[3].move)
            return;
        
        Cakes[0].MoveNext();
        Cakes[1].MoveNext();
        Cakes[2].MoveNext();
        Cakes[3].MoveNext();
        Cakes[4].MoveNext();

        Cake[] demo = new Cake[Cakes.Length];

        for (int i = 0; i < Cakes.Length; i++)
        {
            demo[(i + 1) % demo.Length] = Cakes[i];
        }

        Cakes = demo;

    }

    public void ShitLeft()
    {
        if (Cakes[0].move || Cakes[1].move || Cakes[2].move || Cakes[3].move)
            return;

        Cakes[0].MovePrevious();
        Cakes[1].MovePrevious();
        Cakes[2].MovePrevious();
        Cakes[3].MovePrevious();
        Cakes[4].MovePrevious();

        Cake[] demo = new Cake[Cakes.Length];
        for (int i = 0; i < Cakes.Length - 1; i++)
        {
            demo[i] = Cakes[i + 1];
        }

        demo[demo.Length - 1] = Cakes[0];
        Cakes = demo;

    }


    public bool leanplay = false;

    // Update is called once per frame
    void Update()
    {

        if (Fails.Variable.Value >= HightFails.Variable.Value)
        {
            CanGame = false;
        }



        if (!CanGame)
        {
                panelEnd.LeanMoveY(-10, 1f);

            if (!leanplay)
            {
                if (HightScores.Variable.Value <= Scores.Variable.Value)
                {
                    HightScores.Variable.Value = Scores.Variable.Value;
                    PlayerPrefs.SetInt("HightScores", Convert.ToInt32(Scores.Variable.Value));
                    PlayerPrefs.Save();
                    print("hight");
                }

                panelEnd.LeanMoveY(20, 1f);
                leanplay = true;
            }


        } 
        else
        {

           //     panelEnd.LeanMoveY(20, 1f);

        }




        if (!CanGame)
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
                SceneManager.LoadScene(0);
        }

    }



}
