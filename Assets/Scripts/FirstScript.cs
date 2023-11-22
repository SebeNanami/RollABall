using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int number;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");
        number = 151;
        Debug.Log(number);
        number = 251;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("UpdateƒeƒXƒg");
    }
}

public class Person
{
    private string name;

    public string Getname
    {
        get { return name; }
    }

    public string SetName
    {
        set
        {
            if (value == string.Empty || value != null)
            {
                name = value;
            }
        }
    }

}

public class Rectangle
{

    private float width;
    private float height;

    public float SetWidth
    {
        set { width = value; }
    }

    public float SetHeight
    {
        set { height = value; }
    }

    public float GetArea
    {
        get
        {
            return width * height;
        }
    }

}
