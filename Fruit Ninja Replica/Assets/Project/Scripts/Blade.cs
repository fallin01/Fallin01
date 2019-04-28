using UnityEngine;

public class Blade : MonoBehaviour
{
    public GameObject bladeTrailPrefab;

    public float minCuttingVelocity = 0.001f;

    GameObject currentBladeTrail;
    Camera cam;
    CircleCollider2D circleCollider;
    Vector2 previousPosition;
    Vector2 newPosition;

    bool isCutting = false;
    float velocity;

    private void Start()
    {
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if(isCutting)
        {
            UpdateBlade();
        }
    }

    void UpdateBlade()
    {
        newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = newPosition;

        velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if(velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }

        previousPosition = newPosition;
    }

    void StartCutting()
    {
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 1.5f);
        circleCollider.enabled = false;
    }
}