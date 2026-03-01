using UnityEngine;

namespace Lesson38.Player
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Settings/Weapons/WeaponData")]
    public class WeaponData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public float Damage { get; private set; }
        [field: SerializeField] public float Endurence { get; private set; }
        [field: SerializeField] public float AttackSpeed { get; private set; }
        [field: SerializeField] public float AttackRate { get; private set; }
    }
}