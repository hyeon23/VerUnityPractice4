using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollViewController : MonoBehaviour
{
    private ScrollRect scrollRect;

    public float space = 50;

    public GameObject uiPrefab;

    public List<RectTransform> uiObjects = new List<RectTransform>();

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    public void AddNewUiObject()
    {
        var newUi = Instantiate(uiPrefab, scrollRect.content).GetComponent<RectTransform>();
        uiObjects.Add(newUi);

        float y = 0f;
        for (int i = 0; i < uiObjects.Count; i++)
        {
            uiObjects[i].anchoredPosition = new Vector2(0f, -y);
            y += uiObjects[i].sizeDelta.y + space;
        }
        scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x, y);
    }
}
