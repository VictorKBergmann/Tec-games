using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 vector = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float Magnitude = Random.Range(1, 6);
        GetComponent<Rigidbody2D>().AddForce(vector * Magnitude, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
