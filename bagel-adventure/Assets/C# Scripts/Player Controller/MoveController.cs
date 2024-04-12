using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private bool _aim;
    private Vector3 _mousePos;
    private Vector3 startPos;
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _moveActive;
    [SerializeField] private Transform _firstCircle;
    [SerializeField] private Transform _secondCircle;

    private void Update()
    {
        if (_aim == true)
        {
            if (Input.GetMouseButtonUp(1))
            {
                Debug.Log("truefalse");
                _aim = false;
                _moveActive.SetActive(_aim);
                Application.OpenURL("https://www.youtube.com/watch?v=HIcSWuKMwOw"); //there will be a call to the motion method here
            }
            else
            {
                _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
                _firstCircle.position = new Vector2(_mousePos.x, _mousePos.y);
                _secondCircle.position = new Vector2(_mousePos.x - (_mousePos.x - startPos.x) / 2, _mousePos.y - (_mousePos.y - startPos.y) / 2);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            _aim = true;
            _moveActive.SetActive(_aim);
            _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            startPos = _mousePos;
            Debug.Log("true");
        }
    }
}
