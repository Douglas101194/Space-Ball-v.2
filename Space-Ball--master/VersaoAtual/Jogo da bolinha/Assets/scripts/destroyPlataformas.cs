using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlataformas : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector2(player.transform.position.x-20,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
    }
}
