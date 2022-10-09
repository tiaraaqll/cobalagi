using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptSetting : MonoBehaviour
{

    // Start is called before the first frame update
    public int Setting = 0;
   
   public void onClick () {
    SceneManager.LoadScene(Setting);
    Debug.Log("Pindah ke scene : "+Setting);
   }

   public void PindahScene() 
   {
        Debug.Log("Pindah Scene ke Setting"); 
   }
}
