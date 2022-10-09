using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMute : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;
    Toggle toggle;
    Vector2 handlePosition;
    
    private void Awake()
    {
        toggle = GetComponent <Toggle> ();
        handlePosition = uiHandleRectTransform.anchoredPosition;
        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch (true);
    }

    void OnSwitch(bool on)
    {
        uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
        Debug.Log("Music is : " + toggle.isOn);
    }

    public void OnDestroy() 
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);
    }

    public void Print () 
   {
        Debug.Log("Toggle berfungsi"); 
   }  

}
