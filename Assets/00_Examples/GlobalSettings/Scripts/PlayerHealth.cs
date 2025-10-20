using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerSettings settings;
    private int health;

    private void Awake()
    {
        health = settings.MaxHealth;
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        Debug.Log($"Health: {health}/{settings.MaxHealth}");
    }
}