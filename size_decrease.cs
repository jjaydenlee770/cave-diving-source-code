using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class size_decrease : MonoBehaviour
{

    public GameObject player;
    public float cooldown_time = 5f;

    bool run_once = false; // prevent crash

  // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    IEnumerator SizeDecrease()
    {
        if(run_once)
        {
            yield break;
        }
        
        run_once = true;
        player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        yield return new WaitForSeconds(cooldown_time);
        player.transform.localScale = new Vector3(1f, 1f, 1f);
        Destroy(gameObject);
  
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            GetComponent<Renderer>().enabled = false;

            StartCoroutine(SizeDecrease());
           
        }
        
    }

}
