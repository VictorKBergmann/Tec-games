using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite spriteRock0 = default;
    public Sprite spriteRock1 = default;
    public Sprite spriteRock2 = default;
    public GameObject prefabRock = default;
    Timer time;
    void Start()
    {
        /// <summary>
        /// Use this for initialization
        /// </summary>
        time = gameObject.AddComponent<Timer>();
        time.Duration = 1.0f;
        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] count = GameObject.FindGameObjectsWithTag("Rock");
        if(count.Length < 3)
        {
            if(time.finished || !time.Started)
            {
                time.Run();
                GameObject Rock = Instantiate(prefabRock) as GameObject;
                SpriteRenderer sprite = Rock.GetComponent<SpriteRenderer>();
                int i = Random.Range(0, 3);
                if (i == 0)
                {
                    sprite.sprite = spriteRock0;
                }
                else if (i == 1)
                {
                    sprite.sprite = spriteRock1;
                }
                else
                {
                    sprite.sprite = spriteRock2;
                }
            }
        }
    }
}
