
using System.Collections;

using UnityEngine;

public class follow_player : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    public WaitForSeconds wait = new WaitForSeconds(0.3f);

    void Start()
    {
        player = GameObject.Find("Player");
    }
    
    IEnumerator Slow()
    {
         
         transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.01f);
         yield return wait;
         yield return null;
    }

    void Update()
    {
        StartCoroutine(Slow());
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Collided with bullet");
            Destroy(Enemy);
            Destroy(collision.gameObject);
        }
    }

    


}