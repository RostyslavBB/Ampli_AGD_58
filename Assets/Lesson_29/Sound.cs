using System;
using UnityEngine;

namespace Lesson29
{
    [Serializable]
    public class Sound 
    {
        [field: SerializeField] public string Name { get; private set; }

        [field: SerializeField] public AudioClip Clip { get; private set; }

        [field: SerializeField, Range(0f, 1f)] public float Volume { get; private set; } = 1f;
    }
}