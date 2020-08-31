using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("collision.relativeVelocity: " + collision.relativeVelocity);

        for (int i = 0; collision.contacts.Length != i; i++)
        {
            if (collision.GetContact(i).otherCollider == null) { continue; }

            Debug.DrawLine(collision.GetContact(i).point, collision.GetContact(i).normal * 100 + collision.GetContact(i).point );
            Debug.Log("normal: " + collision.GetContact(i).point + "  contato: " + (collision.GetContact(i).normal + collision.GetContact(i).point)*100);
        }
    }
}
