using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{

    private Renderer RendererProp;
    // Start is called before the first frame update
    void Start()
    {
        RendererProp = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void OnMouseEnter(){
        RendererProp.material.color = Color.green;
        
    }
    private void OnMouseExit(){
        RendererProp.material.color = Color.yellow;
    }
}
