using UnityEngine;

public class status : MonoBehaviour
{
    public float Health, Max_Health;


    [SerializeField]
    private health_ui healthBar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //grabs the players health and puts value into the health bar script.
        healthBar.Max_Health_Set(Max_Health);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Set_Health(float healthchange)
    {
        Health += healthchange;
        //restrics health going from 0 to max health/ sorta like a stop for when limit is reached.
        Health = Mathf.Clamp(Health, 0, Max_Health);

        healthBar.SetHealth(Health);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if(Health > 0)
      {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided with enemy");
            Health -=1;
            healthBar.SetHealth(Health);
        }
      }
      else
      {
        Debug.Log("Player is dead");
        Destroy(gameObject);
      }
        
    
    }
}