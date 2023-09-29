using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script4 : MonoBehaviour
{
     void OnMouseDown(){
        
        Debug.Log(name);
        Debug.Log(transform.position);
        Debug.Log(GetComponent<Renderer>().material.color);
        Debug.Log(GetComponent<Rigidbody>().mass);
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    // private void OnMouseDown()
    // {
    //     // Получаем информацию о компонентах куба
    //     Renderer cubeRenderer = GetComponent<Renderer>();
    //     Transform cubeTransform = transform;

    //     // Выводим информацию в консоль
    //     Debug.Log("Название: " + gameObject.name);
    //     Debug.Log("Координаты: " + cubeTransform.position);
    //     Debug.Log("Цвет: " + cubeRenderer.material.color);
    // }
    
}
