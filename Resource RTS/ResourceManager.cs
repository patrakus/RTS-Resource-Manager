using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour {

    List<Resource> resourcesList = new List<Resource>();

	// Use this for initialization
	void Start () {
        Resource gold = new Resource(100, null, "Gold");

        AddResource(gold);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementResource(int amount, int resourceID)
    {
        resourcesList[resourceID].Count += amount;
    }

    public void DecrementResource(int amount, int resourceID)
    {
        resourcesList[resourceID].Count = amount;
    }

    public void AddResource(Resource newResource)
    {
        resourcesList.Add(newResource);
    }

    public void RemoweResource(Resource resourceTORemove)
    {
        resourcesList.Remove(resourceTORemove);
    }

    public Resource GetResource(int ID) /// TODO: dorobić test dla tej metody
    {
        return resourcesList[ID];
    }
}
