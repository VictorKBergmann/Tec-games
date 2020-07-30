using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnobstaculo : MonoBehaviour
{
    Timer time;
    public GameObject marelopf = default;
    public float pontos = 0, velocidade;
    Personagem personagem;
    // Start is called before the first frame update
    void Start()
    {
        personagem = FindObjectOfType<Personagem>();

        time = gameObject.AddComponent<Timer>();
        time.Duration = 1.4f;

    }

    // Update is called once per frame
    void Update()
    {
        
        if ((time.finished || !time.Started) && !personagem.getBateu())
        {
            float rand = Random.Range(-.5f, .3f);
            time.Duration = 1.4f + rand;
            time.Run();
            
            GameObject marelo = Instantiate(marelopf) as GameObject;

            pontos += 1.0f;
        }
    }
    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 50);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 10 / 50;
        style.normal.textColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        string text = string.Format(pontos.ToString());
        GUI.Label(rect, text, style);
    }
}
