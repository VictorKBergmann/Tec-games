using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    Spawnobstaculo spawnobstaculo;
    Chao[] chao;
    Obstaculo[] obstaculo;
    Personagem personagem;
    Background[] background;
    Vilao vilao;
    private float velocidade = 7;
    // Start is called before the first frame update
    void Start()
    {
        spawnobstaculo = FindObjectOfType<Spawnobstaculo>();
        chao = FindObjectsOfType<Chao>();
        personagem = FindObjectOfType<Personagem>();
        background = FindObjectsOfType<Background>();
        vilao = FindObjectOfType<Vilao>();
    }

    // Update is called once per frame
    void Update()
    {
        //spawnobstaculo.velocidade = velocidade;
        foreach(Chao i in chao)
            i.velocidade = velocidade;
        obstaculo = FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo i in obstaculo)
            i.velocidade = velocidade;
        vilao.velocidade = velocidade;
       
        if (!personagem.getBateu())
            {
            velocidade += .5f * Time.deltaTime;
            }
        else
        {
            velocidade = 0;
            foreach (Background i in background)
                i.velocidade = 0;
        }
       

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (Input.GetKeyDown("r"))
            if (Random.Range(0, 2) == 0)
                SceneManager.LoadScene("GhostFace");
            else
                SceneManager.LoadScene("Freddy");



    }

}
