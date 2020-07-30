using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    Timer deathTimer;
    public float velocidade;
    Personagem personagem;
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();

        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = 10;
        deathTimer.Run();

        transform.position = new Vector3(10, -3.82f, 0);
        transform.GetComponent<Rigidbody2D>();
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
