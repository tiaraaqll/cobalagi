using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptLogin : MonoBehaviour
{

    [SerializeField] Button button;
    // Start is called before the first frame update
    public int Login = 0;

    public void Start () 
    {
        button.onClick.AddListener (
            delegate () 
            {
             SceneManager.LoadScene(Login);
             Debug.Log("Pindah ke scene : "+Login);   
            }
        );
    }

   public void PindahScene() 
   {
        Debug.Log("Pindah Scene ke Login"); 
   }
}
