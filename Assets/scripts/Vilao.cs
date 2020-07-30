using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vilao : MonoBehaviour
{
    private Timer jumpTimer;
    private int jump = 0;
    private Rigidbody2D rb;
    private Personagem personagem;
    public float velocidade;
    private bool caminha = true;
    [SerializeField]
    GameObject prefabExplosion;

    // Start is called before the first frame update
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();
        jumpTimer = gameObject.AddComponent<Timer>();
        
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (personagem.jumped && !jumpTimer.Started)
        {
            jumpTimer.Duration = 3/velocidade;
            jumpTimer.Run();

        }
        if(jumpTimer.finished && personagem.jumped)
        {
            rb.velocity = (new Vector2(0, 15));
            jumpTimer.Started = false;
            personagem.jumped = false;
        }
        //Debug.Log(caminha.ToString());
        if(velocidade == 0 && caminha)
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            caminha = false;
            GameObject explosion = Instantiate<GameObject>(prefabExplosion);
            explosion.transform.position = gameObject.transform.position + Vector3.back;
        }
    }
}
