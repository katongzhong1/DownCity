﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainTree : MonoBehaviour, IPointerClickHandler {

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    #region IPointerClickHandler implementation
    public void OnPointerClick (PointerEventData eventData) {
        Debug.Log ("点击");
    }
    #endregion
}