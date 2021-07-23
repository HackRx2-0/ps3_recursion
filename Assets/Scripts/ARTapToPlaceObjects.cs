using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;
[RequireComponent(typeof(ARRaycastManager))]
public class ARTapToPlaceObjects : MonoBehaviour
{
    public GameObject gameObjectToInstansiate;
    //public TMP_Text _text;
    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;
        if (_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitpose = hits[0].pose;
            //_text.text = hitpose.position.ToString();
            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(gameObjectToInstansiate, hitpose.position, hitpose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitpose.position;
            }
        }
    }
}
