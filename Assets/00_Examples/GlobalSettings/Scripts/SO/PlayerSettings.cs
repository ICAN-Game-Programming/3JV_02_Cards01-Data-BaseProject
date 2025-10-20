using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Config/Player Settings")]
public class PlayerSettings : ScriptableObject
{
    [Header("Movement")]
    public float MoveSpeed = 5f;
    public float JumpForce = 10f;

    [Header("Stats")]
    public int MaxHealth = 100;
}