using UnityEngine;
using UnityEngine.UI;

public class ResourcePresentation : MonoBehaviour {

    public ResourceManager resourceManager;
    public Text resourceCounter;
    public int resourceID;
    public Text toolTip;


	// Use this for initialization
	void Start ()
    {
		if (!resourceManager)
        {
            Debug.LogError("No reference to resourceManager");
        }
        if (!resourceCounter)
        {
            Debug.LogError("No reference to resourceCounter");
        }
        if (!toolTip)
        {
            Debug.LogError("No reference to toolTip");
        }
        if (toolTip.IsActive())
            toolTip.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        resourceCounter.text = resourceManager.GetResource(resourceID).Count.ToString();
	}

    public void ShowToolTip()
    {
        toolTip.text = resourceManager.GetResource(resourceID).Hint;
        toolTip.gameObject.SetActive(true);
    }

    public void HideToolTip()
    {
        toolTip.gameObject.SetActive(false);
    }
}