using UnityEngine;

public class Food : MonoBehaviour
{
    [field: SerializeField] public FoodType FoodType { get; private set; }
}

public enum FoodType
{
    None,
    Fruit,
    Meal,
    Vegetables
}