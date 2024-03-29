﻿using System;
using UnityEngine;

public class AspectUtility : BaseController<AspectUtility>
{
    
    const float ReferenceRatio = 16f / 9f;

    Camera _cam;
    
    int   _currentWidth;
    int   _currentHeight;
    float _originalSize;

    void Update()
    {
        if ( _currentWidth != Screen.width || _currentHeight != Screen.height )
        {
            Init();
        }
    }

    void Init()
    {
        _cam = Camera.main;
        
        if ( !_cam )
        {
            return;
        }
        
        if (_originalSize < float.Epsilon)
        {
            _originalSize = _cam.orthographicSize;
        }

        _currentWidth  = Screen.width;
        _currentHeight = Screen.height;
        var currentRatio = (float)Screen.width / Screen.height;
        var newSize = _originalSize * ReferenceRatio / currentRatio;
        _cam.orthographicSize = newSize;
    }
}
