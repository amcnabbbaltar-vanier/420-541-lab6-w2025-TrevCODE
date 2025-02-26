using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Slider healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if (currentHealth <= 0) {
            Die();
        }

    }
    void Die() {
        if (GameManager.Instance != null) {
            GameManager.Instance.IncrementScore();
            GameManager.Instance.LoadNextScene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
