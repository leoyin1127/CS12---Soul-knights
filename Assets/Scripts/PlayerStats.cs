using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Slider healthBar;
    public Slider manaBar;
    public Slider shieldingBar;

    public float maxHealth = 5;
    public float maxMana = 100;
    public float maxShielding = 5;

    private float currentHealth;
    private float currentMana;
    private float currentShielding;

    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
        currentShielding = maxShielding;

        UpdateBars();
    }
    void Update()
    {
        //test if takedamage function could work
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakeDamage(1);
            
        }
        //test
        if (Input.GetKeyDown(KeyCode.H))
        {
            UseMana(20);
            
        }
    }
    void UpdateBars()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

        manaBar.maxValue = maxMana;
        manaBar.value = currentMana;

        shieldingBar.maxValue = maxShielding;
        shieldingBar.value = currentShielding;
    }

    public void TakeDamage(float damage)
    {
       
        if (currentHealth > 0)
        {
            if (currentShielding > 0)
            {
                currentShielding -= damage;
            }
                else
                {
                    currentHealth -= damage;
                    Debug.Log("00000000000");
                }
        }
        
        UpdateBars();
    }

    public void UseMana(float manaCost)
    {
        if (currentMana > 0)
        {
            currentMana -= manaCost;
        }
        UpdateBars();
    }

    public void AddShielding(float shieldAmount)
    {
        currentShielding += shieldAmount;
        UpdateBars();
    }
}
