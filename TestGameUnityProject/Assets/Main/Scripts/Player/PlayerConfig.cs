using UnityEngine;

[CreateAssetMenu(menuName = "Configs/PlayerConfig", fileName = "PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [field: Header("Movement"),Space(5)]
    [field: SerializeField] public float MoveSpeed { get; private set; }
    [field: SerializeField] public float JumpHeight { get; private set; }
    [field: SerializeField] public float Gravity { get; private set; }
    [field: Header("Health"),Space(5)]
    [field: SerializeField] public int MaxHealth { get; private set; }

}


