using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocontroler : MonoBehaviour
{
    private Personagem personagem;
    private bool flag = true;
    public AudioClip gameover;
    // Start is called before the first frame update
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (personagem.getBateu() && flag)
        {
            GetComponent<AudioSource>().clip = gameover;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = false;
            flag = false;

        }
    }
}
