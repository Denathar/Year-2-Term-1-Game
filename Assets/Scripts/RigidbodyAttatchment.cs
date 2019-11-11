using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAttatchment : MonoBehaviour
{
    public Transform Parent;
    public Transform Child;
    public bool IsParent = true;

    private void Update()
    {
        if (IsParent == true)
        {
            Child.SetParent(Parent);
        }
        else
        {
            Child.SetParent(null);
        }
    }
    void ParentSwitch(bool Switch)
    {
        IsParent = Switch;

    }
    
}
