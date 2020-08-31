using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] ghostfaceRender;
    private void Start()
    {
        GetComponent<MeshRenderer>().materials = ghostfaceRender;

    }
}
