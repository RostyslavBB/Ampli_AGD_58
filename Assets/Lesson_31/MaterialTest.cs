using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson31
{
    public class MaterialTest : MonoBehaviour
    {
        [SerializeField] private Material _material;

        [SerializeField] private List<Color> _colors;

        private void Start()
        {
            StartCoroutine(ChangeColor());
        }

        private IEnumerator ChangeColor()
        {
            for (int i = 0; i < _colors.Count; i++)
            {
                yield return new WaitForSeconds(3f);

                _material.color = _colors[i];
            }
        }

        private void OnApplicationQuit()
        {
            _material.color = Color.white;
        }
    }
}