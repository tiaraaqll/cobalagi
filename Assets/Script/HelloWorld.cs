using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string varString = "ini string";
    public float varFloat = 5.5f;

    private void Awake() {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
           Debug.Log(Time.fixedDeltaTime);
           
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Debug.Log("GetKeyDown");
        } 
        if (Input.GetKeyUp(KeyCode.A)) 
        {
            Debug.Log("GetKeyIp");
        } 
    }

    //FixedUpdate untuk pergerakan, dipisah dari teknikal
    private void FixedUpdate() {
        //membuat timpestamp
    }
}
