using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBear : MonoBehaviour
{

    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;

    // Start is called before the first frame update

    void Start()
    {
        transform.localScale *= 4;
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();

    }

    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        if (deathTimer.finished)
        {
            Destroy(gameObject);
        }
    }


}
