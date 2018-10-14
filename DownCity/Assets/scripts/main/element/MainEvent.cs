using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainEvent : MonoBehaviour {

    public Image img;

	public void EventFunction () {
        switch(gameObject.name) {
            case "tree": Debug.Log("===>点击了 树"); break;
            case "market": Debug.Log("===>点击了 市场"); break;
            case "blacksmith": Debug.Log("===>点击了 铁匠铺"); break;
            case "manor": Debug.Log("===>点击了 庄园"); break;
            case "pub": Debug.Log("===>点击了 酒馆"); break;
            case "warehouse": Debug.Log("===>点击了 仓库"); break;
            case "cemetery": Debug.Log("===>点击了 墓地"); break;
            case "battle": Debug.Log("===>点击了 火堆"); break;
            case "castle": Debug.Log("===>点击了 城堡"); break;
        }
    }

}