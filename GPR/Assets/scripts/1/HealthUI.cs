using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Text hitText;
    private Damage damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = GetComponent<Damage>();
        damage.OnDamage += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI(int health)
    {
        Debug.Log(health);
        hitText.text = "Health:" + " " + health.ToString();
    }
}
