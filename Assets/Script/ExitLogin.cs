using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLogin : MonoBehaviour
{

    [SerializeField] Button button;
    // Start is called before the first frame update
    public int MainMenu = 0;

    public void Start () 
    {
        button.onClick.AddListener (
            delegate () 
            {
             SceneManager.LoadScene(MainMenu);
             Debug.Log("Pindah ke scene : "+MainMenu);   
            }
        );
    }

   public void PindahScene() 
   {
        Debug.Log("Pindah Scene ke Main Menu"); 
   }
}
