using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnobstaculo : MonoBehaviour
{
    public Font font;
    Timer time, pontos;
    public GameObject marelopf = default;
    public float velocidade;
    Personagem personagem;
    // Start is called before the first frame update
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();

        time = gameObject.AddComponent<Timer>();
        time.Duration = 1.4f;
        pontos = gameObject.AddComponent<Timer>();
        pontos.Duration = 100000000000000f;
        pontos.Run();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((time.finished || !time.Started) && !personagem.getBateu())
        {
            float rand = UnityEngine.Random.Range(-.5f, .3f);
            time.Duration = 1.4f + rand;
            time.Run();
            
            GameObject marelo = Instantiate(marelopf) as GameObject;
            
        }
        if(personagem.getBateu()) pontos.pause();
    }


    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;
        GUIStyle style = new GUIStyle();
        style.font = font;
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 7 / 50;
        style.normal.textColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        if (!personagem.getBateu())
        {
            Rect rect = new Rect(0, 0, w, h);
            string text = string.Format((Math.Round(pontos.Elapised)).ToString());
            GUI.Label(rect, text, style);
        }
        else
        {

            if (PlayerPrefs.GetInt("highScore") < Math.Round(pontos.Elapised)) {
                PlayerPrefs.SetInt("highScore", (int)Math.Round(pontos.Elapised));
            }

            Rect rect3 = new Rect(16* w/50, 20 * h / 50, w, h);
            GUI.Label(rect3, "GAME OVER", style);

            Rect rect1 = new Rect(15 * w / 50, 30 * h / 50, w, h);
            string pontos1 = string.Format((Math.Round(pontos.Elapised)).ToString());
            GUI.Label(rect1, pontos1, style);


            Rect rect2 = new Rect(35 * w / 50, 30 * h / 50, w, h);
            string hs = string.Format(PlayerPrefs.GetInt("highScore").ToString());
            GUI.Label(rect2, hs, style);

        }
        

    }
}
