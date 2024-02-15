using System.Collections;
using System.Collections.Generic;
using UnityEngineInternal;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame updat
    public void TakeDamage(float damage)
    {
        slider.value -= damage;
    }
    public void SetHealth(float health)
    {
        slider.value = health;
    }
}
