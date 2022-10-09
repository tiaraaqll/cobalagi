using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform rect;

    void Start()
    {
        if (rect==null)
        rect = GetComponent <RectTransform> ();
        var button = GetComponent <Button> ();
        
        if (button==null)
            gameObject.AddComponent <Button> ();
        
        Debug.Log(rect);
        Debug.Log(button);
    }

    // Update is called once per frame
    //float timer = 0;
    void Update()
    {
        //mengatur ukuran screen
        if(rect.anchoredPosition.y >= 0)
            return;

        rect.anchoredPosition += new Vector2 (0,1) * Time.deltaTime;
    }
}
