using System.Collections.Generic;
using UnityEngine;

public class TestReorder : MonoBehaviour
{
    public List<TestChild> list1;
    
}

[System.Serializable]
public class TestChild {

    public Color[] color;
}