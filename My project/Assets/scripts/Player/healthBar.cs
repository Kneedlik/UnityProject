using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class healthBar : MonoBehaviour
{
    public Slider slider;
    public bool WorldSpace = true;

    private void Start()
    {
        if(WorldSpace)
        {
            transform.SetParent(GameObject.FindWithTag("WorldCanvas").transform);
        }
       
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }

   public void SetHealth(int health)
    {
        slider.value = health;
    }

    
   
}
