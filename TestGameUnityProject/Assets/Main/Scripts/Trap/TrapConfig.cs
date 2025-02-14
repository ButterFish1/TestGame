
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/TrapConfig",fileName = "TrapConfig")]
public class TrapConfig : ScriptableObject
{
    [field: SerializeField] public int Damage { get; private set; }
}

