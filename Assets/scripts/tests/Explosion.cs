using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An explosion
/// </summary>
public class Explosion : MonoBehaviour
{
    // cached for efficiency
    Animator anim;
    Timer animDuration;
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        anim = GetComponent<Animator>();
        animDuration = gameObject.AddComponent<Timer>();
        animDuration.Duration = anim.GetCurrentAnimatorStateInfo(0).length;
        animDuration.Run();

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (animDuration.finished)
        {
            Destroy(gameObject);
        }
        // destroy the game object if the explosion has finished its animation

    }
}
