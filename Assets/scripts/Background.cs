using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float velocidade = .5f;
    void Update()
    {
        transform.position += Vector3.left * (velocidade * Time.deltaTime);
        if (transform.position.x <= -15f)
        {
            transform.position = new Vector3(22.68f, -2, 1);
        }

    }
}
