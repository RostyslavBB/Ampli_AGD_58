using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class CollectionTest : MonoBehaviour
{
    [SerializeField] private List<int> _ages;

    private Queue<int> _queue = new();

    private Stack<int> _stack = new();

    private Dictionary<string, int> _dictionary = new();

    [SerializeField] private TMP_Text _agesText;

    [SerializeField] private int _ageToRemove;
    [SerializeField] private int _ageNeedToContain;

    private void Start()
    {
        // Queue 

        _queue.Enqueue(54);
        _queue.Enqueue(1);
        _queue.Enqueue(2);

        _queue.Dequeue();

        _queue.Peek();

        int queueCount = _queue.Count;


        // Stack

        _stack.Push(52);
        _stack.Push(41);
        _stack.Push(38);

        _stack.Pop();

        _stack.Peek();

        int stackCount = _stack.Count;


        // Dictionary

        _dictionary.Add("Maksym", 42);

        _dictionary["Maksym"] = 58;

        Debug.Log(_dictionary["Maksym"]);

        _dictionary.Remove("Maksym");

        _dictionary["Maksym"] = 31;

        if (_dictionary.ContainsKey("Maksym"))
            Debug.Log("Contain");
        else
            Debug.Log("Not Contain");

        _dictionary.TryGetValue("Maksym", out int age);

        Debug.Log(age);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
            UpdateAgeText();
        else if (Input.GetKeyDown(KeyCode.U))
            AddListElement();
        else if (Input.GetKeyDown(KeyCode.I))
            RemoveListElement();
        else if (Input.GetKeyDown(KeyCode.F))
            ContainListElement();
        else if (Input.GetKeyDown(KeyCode.G))
            CountListElement();
        else if (Input.GetKeyDown(KeyCode.H))
            ClearListElement();
    }

    private void AddListElement()
    {
        _ages.Add(Random.Range(0, 100));

        UpdateAgeText();
    }

    private void RemoveListElement()
    {
        _ages.Remove(_ageToRemove);

        UpdateAgeText();
    } 

    private void ContainListElement()
    {
        if (_ages.Contains(_ageNeedToContain))
            Debug.Log("Contain");
        else
            Debug.Log("Not Contain");
    }

    private void CountListElement()
    {
        Debug.Log(_ages.Count);
    }

    private void ClearListElement()
    {
       _ages.Clear();

        UpdateAgeText();
    }

    private void UpdateAgeText()
    {
        StringBuilder stringBuilder = new();

        foreach (int age in _ages)
        {
            stringBuilder.Append(age);
            stringBuilder.Append(" ");
        }

        _agesText.text = stringBuilder.ToString();  
    }
}
