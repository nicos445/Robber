using UnityEngine;

public class CharacterSlideControls : MonoBehaviour
{
    [SerializeField] private float dragSpeed;
    [SerializeField] private float clamp;

    private Camera mainCamera;
    private Vector3 previousMousePosition;

    private float zAtStart;
    private bool beginTouch = false;

    private void Start()
    {
        mainCamera = Camera.main;

        zAtStart = transform.position.z;
    }

    private void Update()
    {
        if ((Input.touchCount == 1 || Input.GetMouseButton(0)))
        {
            if (!beginTouch)//on first touch
            {
                beginTouch = true;

                previousMousePosition = Input.mousePosition;//last position = current position
                previousMousePosition.z = zAtStart;//we don't keep z delta
            }

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = zAtStart;

            //delta is (currentPosition - lastPosition) * dragSpeed
            float mouseDelta = (mainCamera.ScreenToWorldPoint(mousePosition).x - mainCamera.ScreenToWorldPoint(previousMousePosition).x) *
                dragSpeed;

            //new position is current one + delta on x
            transform.position = new Vector3(Mathf.Clamp(mouseDelta + transform.position.x, -clamp, clamp), transform.position.y, zAtStart);

            previousMousePosition = mousePosition;
        }

        else if (beginTouch)
        {
            beginTouch = false;
        }
    }

    private void OnDisable()
    {
        beginTouch = false;
    }
}
