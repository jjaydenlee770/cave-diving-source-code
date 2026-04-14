using UnityEngine;
using TMPro;

public class wintotouch : MonoBehaviour
{
    public TextMeshProUGUI wintext;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if(gameObject.CompareTag("Player"))
        {
            wintext.text = "You win";
            Destroy(gameObject);
        }
        else
        {
            wintext.text = "you didn't win yet. continue down the cave";
        }
        
        
        
    }
}
