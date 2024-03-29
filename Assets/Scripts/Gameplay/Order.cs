﻿using UnityEngine;

public class Order : PlaceableObject
{
    public string Name;

    public override void Place(Place place)
    {
        base.Place(place);
        transform.SetParent(place.transform);
        transform.localPosition = Vector3.zero;
        var rt = GetComponent<RectTransform>();
        rt.anchorMin        = Vector2.zero;
        rt.anchorMax        = Vector2.one;
        rt.sizeDelta        = Vector2.zero;
        rt.anchoredPosition = Vector2.zero;
    }
}
