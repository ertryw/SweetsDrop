using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item_Color
{
    Red,Green,Yellow,Purple,Blue
}


public class Item : MonoBehaviour
{

    public Item_Color color;
    public Texture2D[] color_images;
    SpriteRenderer  sprite_renderer;
    public GameObject splash;
    public GameObject scored_good;
    public GameObject scored_bad;

    public AudioClip clip_good;
    public AudioClip clip_bad;
    GameController gController;

    void Awake()
    {
        int r = Random.Range(0,color_images.Length-1);
        Sprite mySprite = Sprite.Create(color_images[r], new Rect(0.0f, 0.0f, color_images[r].width, color_images[r].height), new Vector2(0, 0));
        sprite_renderer = GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = mySprite;
        gController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    public void Splash(Vector3 pos,Item_Color _color)
    {
        Vector3 p1 = new Vector3(pos.x + 1.8f, pos.y, pos.z);


        if (_color == color)
        {
            SoundMenager.Play(clip_good);
            Instantiate(scored_good, p1, Quaternion.identity);
            gController.AddScore();
        }
        else
        {
            SoundMenager.Play(clip_bad);
            Instantiate(scored_bad, p1, Quaternion.identity);
            gController.AddFailsScore();
        }



        Instantiate(splash, p1, Quaternion.identity);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
