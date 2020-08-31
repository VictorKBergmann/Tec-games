using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    Timer deathTimer;
    public float velocidade;
    Personagem personagem;
    public Sprite o1, o2, o3, o4, o5, o6, o7;
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();

        transform.position = new Vector3(10, -4.7f,0);
        transform.GetComponent<Rigidbody2D>();



        int rand = Random.Range(1, 8);
        switch (rand)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = o1;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = o2;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = o3;
                break;
            case 4:
                GetComponent<SpriteRenderer>().sprite = o4;
                break;
            case 5:
                GetComponent<SpriteRenderer>().sprite = o5;
                break;
            case 6:
                GetComponent<SpriteRenderer>().sprite = o6;
                break;
            case 7:
                GetComponent<SpriteRenderer>().sprite = o7;
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidade, 0);
    }
}
