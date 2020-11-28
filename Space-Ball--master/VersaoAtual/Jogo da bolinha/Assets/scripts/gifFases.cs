using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gifFases : MonoBehaviour {

    public Texture2D[] framesFase1;
    public Texture2D[] framesFase2;

    public Texture2D[] framesFase3;
    public Texture2D[] framesFase4;
    public int fps = 10;

    public GameObject player;  

    public GameObject PausarBtn;  
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    void Start()
    {

    }
    void Update()
    {
        torcaDeFundo ( fps, framesFase1);
        if(player.GetComponent<Player>().getPontuacao()/15==1)
        {
            torcaDeFundo ( fps, framesFase2);
        }
        if(player.GetComponent<Player>().getPontuacao()/15==2)
        {
          
            torcaDeFundo ( fps, framesFase3);
        }
        if(player.GetComponent<Player>().getPontuacao()/15==3)
        {
            
            torcaDeFundo ( fps, framesFase4);
        }
      
    }
    public void torcaDeFundo (int fpsParametro, Texture2D[] framesFase)
    {
        int index = (int)(Time.time * fpsParametro) % framesFase.Length;
        GetComponent<RawImage>().texture = framesFase[index];
    }
}
