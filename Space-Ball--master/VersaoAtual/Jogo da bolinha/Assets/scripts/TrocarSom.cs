using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarSom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;  

    private AudioSource audioData;

    public AudioClip otherClip;

    
    public AudioClip otherClip2;

    public AudioClip otherClip3;

    public AudioClip otherClip4;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Player>().getPontuacao()/15==1 &&audioData.clip != otherClip )
        {
            
            audioData.clip = otherClip;
            audioData.Play(0);
        }
        if(player.GetComponent<Player>().getPontuacao()/15==2 &&audioData.clip != otherClip2 )
        {
            
            audioData.clip = otherClip2;
            audioData.Play(0);
        }
        if(player.GetComponent<Player>().getPontuacao()/15==3 &&audioData.clip != otherClip3 )
        {
            
            audioData.clip = otherClip3;
            audioData.Play(0);
        }
           if(player.GetComponent<Player>().getPontuacao()/15==4 &&audioData.clip != otherClip4 )
        {
            
            audioData.clip = otherClip4;
            audioData.Play(0);
        }
    }
    public void primeiraTroca ()
    {
       
    }
}
