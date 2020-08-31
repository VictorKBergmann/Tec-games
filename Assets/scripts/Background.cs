using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float velocidade = 5f;
    public Sprite back1, back2, back3, back4;


    private void Start()
    {
        float rand = Random.Range(0, 4);
        if (rand == 0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = back1;
        else if (rand == 1)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = back2;
        else if (rand == 2)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = back3;
        else
            this.gameObject.GetComponent<SpriteRenderer>().sprite = back4;
    }
    void Update()
    {
        transform.position += Vector3.left * (velocidade * Time.deltaTime);
        if (transform.position.x <= -30f)
        {
            float resto = transform.position.x + 102.8f;
            transform.position = new Vector3(resto, 0.3f, 1);
            float rand = Random.Range(0, 4);
            if(rand == 0)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = back1;
            else if (rand == 1)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = back2;
            else if (rand == 2)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = back3;
            else
                this.gameObject.GetComponent<SpriteRenderer>().sprite = back4;
        }

    }
}
