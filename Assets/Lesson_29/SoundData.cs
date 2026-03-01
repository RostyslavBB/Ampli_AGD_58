using System.Collections.Generic;
using UnityEngine;

namespace Lesson29
{
    [CreateAssetMenu(fileName = "SoundData", menuName = "Custom Audio/SoundData")]
    public class SoundData : ScriptableObject
    {
        [field: SerializeField] public List<Sound> Sounds { get; private set; }
    }
}