using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tree : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Debug.Log("update");
	}

    #region IPointerClickHandler implementation
    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("点击");
    }
    #endregion
}