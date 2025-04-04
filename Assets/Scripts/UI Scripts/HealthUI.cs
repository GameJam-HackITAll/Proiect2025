using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    [SerializeField] public int playerHealth;
    [SerializeField] public TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = playerHealth.ToString("D2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseHealth()
    {
        playerHealth++;
        healthText.text = playerHealth.ToString("D2");
    }

    public void DecreaseHealth()
    {
        playerHealth--;
        healthText.text = playerHealth.ToString("D2");
    }
}