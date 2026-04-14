using System.Collections;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{

    float speed;
    float walking_speed = 2f;
    float running_speed = 20f;
    public float stamina_bar = 100f;

    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    IEnumerator wait()
    {
       while(true)
       {
        
            yield return new WaitForSeconds(1f);
           
            stamina_bar += 1f;
      
           
       }
       
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float x_input = Input.GetAxis("Horizontal");
        float y_input = Input.GetAxis("Vertical");
       

        
        if(Input.GetKey(KeyCode.LeftShift) && stamina_bar > 0)
        {
         
          speed = running_speed;
          stamina_bar -= 1f;
          
          if(stamina_bar <= 0)
          {
              speed = walking_speed;
              if(stamina_bar <= 1f && !Input.GetKeyDown(KeyCode.LeftShift))
             {
                    
                    StartCoroutine(wait());
             }
              else
            {
                if(stamina_bar >= 100)
                {
                    StopCoroutine(wait());
                    
                }
                   
            }
              
          }
        }
        else
        {
            speed = walking_speed;
        }
             

        Vector2 movement_leftright = new Vector2(x_input, y_input) * speed * Time.deltaTime;
        
        
        transform.Translate(movement_leftright);



    }
}
