﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBear : MonoBehaviour
{
    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;

    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(1, 5);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();


    }
    private void Update()
    {
        if (deathTimer.finished)
        {
            Destroy(gameObject);
        }
    }

}