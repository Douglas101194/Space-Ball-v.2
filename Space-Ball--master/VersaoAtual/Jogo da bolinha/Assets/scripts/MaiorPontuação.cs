using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;

public class MaiorPontuação : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
 
    public static int highscore;

    public static int pontuacaotxt=0;
    private Scene scenaAtiva;

    public GameObject player;   
    public bool ValidarObjetoScena = true;
  
    //static TextAsset arquivo ;

    string scenaNome="";
   // private bool 
    void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
    void Start()
    { 
        scenaNome=scenaAtiva.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("highscore")){
            highscore= PlayerPrefs.GetInt("highscore");
        }else{
            highscore=0;
        }
        if(scenaNome!=scenaAtiva.name)
        {
            player=GameObject.Find("Player");
        }
        if(scenaAtiva.name=="Jogo")
        {
            score=player.GetComponent<Player>().getPontuacao();
        }
        if (score > highscore){
            highscore = score;
            PlayerPrefs.SetInt("highscore",highscore);
           
        }
        scenaAtiva = SceneManager.GetActiveScene();
        if(scenaAtiva.name=="MenuInicio")
        {
            ProcurarObjeto ();
        }
     
    }


 
  
    void ProcurarObjeto ()
    {
        if(ValidarObjetoScena)
        {   
            GameObject textoPontuação = GameObject.Find("pontuacaoFinal");
            if(PlayerPrefs.HasKey("highscore")){
                textoPontuação.GetComponent<UnityEngine.UI.Text>().text = "BEST SCORE : "+ PlayerPrefs.GetInt("highscore");
            }else{
                 textoPontuação.GetComponent<UnityEngine.UI.Text>().text = "BEST SCORE : "+"0";
            }
            
            ValidarObjetoScena = false;
        }
    }

}
