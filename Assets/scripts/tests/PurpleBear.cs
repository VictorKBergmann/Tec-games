using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBear : MonoBehaviour
{
    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;


    float totalJumpDelaySeconds = 1, elapsedJumpDelaySeconds = 0;
    float minX = -4, maxX = 4, minY = -2, maxY = 2; 
    void Start()
    {
        transform.localScale *= 2;
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();

    }
    private void Update()
    {
        elapsedJumpDelaySeconds += Time.deltaTime;
        float i = deathTimer.Elapised;
        if(elapsedJumpDelaySeconds >= totalJumpDelaySeconds)
        {
            transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            elapsedJumpDelaySeconds = 0;
        }
        if (deathTimer.finished)
        {
            Destroy(gameObject);
        }
    }

}
