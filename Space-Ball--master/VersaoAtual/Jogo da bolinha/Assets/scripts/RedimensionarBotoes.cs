using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RedimensionarBotoes : MonoBehaviour
{
    // Start is called before the first frame update
    private int width=0;
    private int height=0;

    void Start()
    {
       width=Screen.width; 
       height=Screen.height; 
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name=="MenuInicio")
        {
            if(width==1920 && height==1080)
            {
                
            }
        }
        
    }
}
