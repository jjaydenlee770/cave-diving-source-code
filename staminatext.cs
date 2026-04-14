using UnityEngine;
using TMPro;

public class staminatext : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public move stamina_script;
    public float stamina_bar;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       stamina_bar = stamina_script.stamina_bar;
        text.text = "stamina: " + stamina_bar.ToString("F0");
    }
}

