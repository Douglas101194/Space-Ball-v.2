using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    private bool isJumping=false;
    public GameObject plataforma;
    public GameObject PlataformaSpawn;
    public GameObject PlataformaColoridaAzul;
    public GameObject PlataformaSpawnAzul;
    public GameObject PlataformaColoridaPreta;
    public GameObject PlataformaSpawnPretaSpawn;
    public GameObject spawnGameObject;
    public GameObject txt; 
    private int pontuacao=0;
    private AudioSource audioData;

    private double tamanhoPulo=1.5;
    

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       rig.velocity = new Vector2(Speed, rig.velocity.y); 
       if (Input.GetMouseButton(0)  && !isJumping)
       {     
            rig.AddForce(Vector2.up , ForceMode2D.Impulse);
            if(transform.position.y>=tamanhoPulo)
            {
              isJumping=true;
               
            }
       }else{
          rig.AddForce(Vector2.up*0, ForceMode2D.Impulse); 
       }
        
       
       if(transform.position.y<-50)
       {
        SceneManager.LoadScene("FimJogo");
       }
       txt.GetComponent<UnityEngine.UI.Text>().text = "score :"+pontuacao.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        tamanhoPulo = collision.gameObject.transform.position.y+1.5;
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
        if(collision.gameObject.tag == "plataforma")
        {
            audioData.Play(0);
            pontuacao++;
            isJumping=false;
            collision.gameObject.tag = "plataformaSemPontuacao";
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
         if(col.gameObject.tag == "spawn")
        {
            spawnPlataforma();
        }
    }
    public bool JumpingValidation ()
    {
        if(transform.position.y>=5)
        {
            isJumping=true;
        }
        return isJumping;
    }
    public int  getPontuacao()
    {
        return pontuacao;
    }
    private void spawnPlataforma()
    {
       
        Instantiate(spawnGameObject, new Vector3(this.transform.position.x+27+Speed,Random.Range(0,5), 0), Quaternion.identity);
        if(pontuacao<13)
        {
            spawnPlataformaFase1();
        }
        if(pontuacao>=13 && pontuacao<26)
        {
            Speed++;
            spawnPlataformaFase2();
        }
        if(pontuacao>=26)
        {
            Speed++;
            spawnPlataformaFase3();
        }
    }
    private int almentarDistancia()
    {
        if(pontuacao%50>0)
        {
            return 50/10 ;
        }
        else
        {
            return 0;
        }
         
    }
    private void spawnPlataformaFase1()
    {
        Instantiate(plataforma, new Vector3(this.transform.position.x+27+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(plataforma, new Vector3(this.transform.position.x+34+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(plataforma, new Vector3(this.transform.position.x+41+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
      


    }
    private void spawnPlataformaFase2()
    {
        Instantiate(PlataformaColoridaAzul, new Vector3(this.transform.position.x+27+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(PlataformaColoridaAzul, new Vector3(this.transform.position.x+34+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(PlataformaColoridaAzul, new Vector3(this.transform.position.x+41+(pontuacao/10)+Speed,Random.Range(0,5), 0), Quaternion.identity);
      
    }
    private void spawnPlataformaFase3()
    {
        Instantiate(PlataformaColoridaPreta, new Vector3(this.transform.position.x+27+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(PlataformaColoridaPreta, new Vector3(this.transform.position.x+34+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        Instantiate(PlataformaColoridaPreta, new Vector3(this.transform.position.x+41+Speed+(pontuacao/10),Random.Range(0,5), 0), Quaternion.identity);
        
    }
  
}
