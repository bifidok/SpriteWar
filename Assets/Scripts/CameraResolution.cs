using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    private Camera _camera;
    private float _defaultWidth;
    void Start()
    {
        _camera = Camera.main;
        _defaultWidth = _camera.orthographicSize * _camera.aspect;
    }

    void Update()
    {
        _camera.orthographicSize = _defaultWidth / _camera.aspect;
    }
}
