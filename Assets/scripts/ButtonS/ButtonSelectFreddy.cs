using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSelectFreddy : MonoBehaviour
{
    public void OnClick()
    {

        SceneManager.LoadScene("Freddy");

    }
}
