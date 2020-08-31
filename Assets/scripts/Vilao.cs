using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vilao : MonoBehaviour
{
    private Timer jumpTimer;
    //private int jump = 0;
    private Rigidbody2D rb;
    private Personagem personagem;
    public float velocidade;
    private bool caminha = true;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 1;
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
            rb.velocity = (new Vector2(0, 20));
            jumpTimer.Started = false;
            personagem.jumped = false;
        }        
        if(velocidade == 0 && caminha)
        {
            transform.position += Vector3.right * Time.deltaTime * 3;
            GetComponent<Animator>().SetBool("rodando", true);
        }
        transform.rotation = new Quaternion();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            caminha = false;
            
        }
    }
}
