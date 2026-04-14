using Unity.VisualScripting;
using UnityEngine;

public class health_ui : MonoBehaviour
{
//recently learned that i c an make a bunch of variables in one line.
    public float Health, Max_Health, Width, Height;
    [SerializeField]
    private RectTransform health_bar;

    public void Max_Health_Set(float max_health)
    {
        Max_Health = max_health;
    }   

    public void SetHealth(float health)
    {
        Health = health;
        //turns new with into percentage of health and max health, then multiplies it by the width of the health bar to get the new width of the health bar.
        float newWidth = (Health / Max_Health) * Width;
        
        //changes size wit new width.
        health_bar.sizeDelta = new Vector2(newWidth, Height);
    }
}
