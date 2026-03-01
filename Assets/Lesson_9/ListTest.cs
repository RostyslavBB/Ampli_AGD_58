using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    [SerializeField] private List<Food> _foods;

    [SerializeField] private FoodType _foodTypeToRemove;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (Food food in _foods)
            {
                if (food.FoodType == _foodTypeToRemove)
                {
                    Destroy(food.gameObject);
                }
            }
        }
    }
}
