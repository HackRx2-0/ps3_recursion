using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;
[RequireComponent(typeof(ARRaycastManager))]
public class ARTapToPlaceObjects : MonoBehaviour
{
    public GameObject portal;
    public GameObject Oven;
    public GameObject WashingMaching;
    public GameObject washer;
    private GameObject gameObjectToInstansiate;
    //public TMP_Text _text;
    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;
    private bool portalInstantiated;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject canvas;
    private void Awake()
    {
        canvas.SetActive(false);
        gameObjectToInstansiate = portal;
        portalInstantiated = false;
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }


    public void OnclickOven()
    {
        gameObjectToInstansiate = Oven;
    }
    public void OnclickWashingMaching()
    {
        gameObjectToInstansiate = WashingMaching;
    }
    public void OnclickWasher()
    {
        gameObjectToInstansiate = WashingMaching;
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
        if (!portalInstantiated && _arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitpose = hits[0].pose;
            //_text.text = hitpose.position.ToString();
            portalInstantiated = true;
            canvas.SetActive(true);
            Instantiate(gameObjectToInstansiate, hitpose.position, hitpose.rotation);
        }
        if (portalInstantiated && _arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            Destroy(spawnedObject);
            var hitpose = hits[0].pose;
            spawnedObject = Instantiate(gameObjectToInstansiate, hitpose.position, hitpose.rotation);
        }
    }
}
