using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Stack")]
public class Stack : ScriptableObject
{
    public GameObject prefab;
    private Stack<GameObject> stack = new Stack<GameObject>();

    public int GetStackCount()
    {
        return stack.Count;
    }

    public void AddStack(GameObject prefab)
    {
        prefab.SetActive(false);
        stack.Push(prefab);
    }

    public void ClearStack()
    {
        stack.Clear();
    }

    public bool ContainsInStack(GameObject prefab)
    {
        return stack.Contains(prefab);
    }

    public void FullStack(int count)
    {
        if (count == 0)
        {
            return;
        }

        GameObject newPrefab = Instantiate(prefab);
        AddStack(newPrefab);

        count--;
        FullStack(count);
    }

    public GameObject GetPrefabInStack()
    {
        GameObject newPrefab = stack.Pop();
        newPrefab.SetActive(true);

        return newPrefab;
    }

    public GameObject InstantiateNewPrefab(Vector3 position , Quaternion rotation)
    {
        GameObject newPrefab;

        if(GetStackCount() > 0)
        {
            newPrefab = GetPrefabInStack();

            newPrefab.transform.position = position;
            newPrefab.transform.rotation = rotation;
        }

        else
        {
            Debug.Log("Stack is empty!!");
            newPrefab = Instantiate(this.prefab);
            AddStack(newPrefab);
            newPrefab = Instantiate(this.prefab, position, rotation);
        }

        return newPrefab;
    }
}
