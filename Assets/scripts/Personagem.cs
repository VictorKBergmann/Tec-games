using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private Timer jumpTimer;
    private Rigidbody2D rb;
    private bool bateu = false;
    public bool jumped = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        jumpTimer = gameObject.AddComponent<Timer>();
        jumpTimer.Duration = 0.764f;


    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && !jumpTimer.Running && !bateu)
        {
            rb.velocity = (new Vector2(0, 15));
            jumpTimer.Run();
            jumped = true;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            bateu = true;
        }
    }
    public bool getBateu()
    {
        return bateu;
    }

}
