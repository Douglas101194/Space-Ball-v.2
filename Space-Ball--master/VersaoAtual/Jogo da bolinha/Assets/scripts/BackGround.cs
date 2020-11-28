using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;  

    public GameObject backgroundGameObj;  
  //  SpriteRenderer spriteRenderer 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Player>().getPontuacao()>5)
        {
            backgroundGameObj.GetComponent<SpriteRenderer>().sprite=Resources.Load<Sprite>("Fundo 01");
            backgroundGameObj.transform.localScale= new Vector3(9.02f,5.5f,1);
        }
        if(player.GetComponent<Player>().getPontuacao()>10)
        {
            backgroundGameObj.GetComponent<SpriteRenderer>().sprite=Resources.Load<Sprite>("Fundo 02");
            backgroundGameObj.transform.localScale= new Vector3(9.02f,5.5f,1);
        }
        if(player.GetComponent<Player>().getPontuacao()>15)
        {
            backgroundGameObj.GetComponent<SpriteRenderer>().sprite=Resources.Load<Sprite>("Plano Fundo");
            backgroundGameObj.transform.localScale= new Vector3(9.02f,5.5f,1);
        }
    }
}
