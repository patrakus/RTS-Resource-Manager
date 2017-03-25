using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour {

    List<Resource> resourcesList = new List<Resource>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void IncrementResource( int amount, int resourceID)
    {
        throw new System.Exception();
    }

    void DecrementResource(int amount, int resourceID)
    {
        throw new System.Exception();
    }

    void AddResource(Resource newResource)
    {
        throw new System.Exception();
    }

    void RemoweResource(Resource Resource)
    {
        throw new System.Exception();
    }

    Resource GetResource(int ID) /// TODO: dorobić test dla tej metody
    {
        foreach (var item in resourcesList)
        {
            if (item.ID == ID)
                return item;
        }

        return null;
    }
}
