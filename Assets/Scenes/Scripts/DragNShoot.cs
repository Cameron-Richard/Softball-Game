using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
  public float power = 10f;
  public Rigidbody2D rb;

  public Vector2 minPower;
  public Vector2 maxPower;

   TrajectoryLine tl;

  Camera cam;
  Vector2 force;
  Vector3 startPoint;
  Vector3 endPoint;

  public bool isStill = true;
  public PowerShot aC;

  public AudioSource mySounds;
  public AudioClip launchSound;
  public bool launchable = true;

  [SerializeField] PauseMenu iP;

  private void Start()
  {
    cam = Camera.main;
    tl = GetComponent<TrajectoryLine>();
  }

  private void Update()
  {

    if(rb.velocity == new Vector2(0, 0) &&iP.isPaused == false)
    {
      isStill = true;
    }

    else 
    {
      isStill = false;
    }

    if (Input.GetMouseButtonDown(0) &&isStill == true)
    {
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        startPoint.z = 15;
    }

    if (Input.GetMouseButton(0) &&isStill == true)
    {
      Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
      currentPoint.z = 15;
      tl.RenderLine(startPoint, currentPoint);
    }

    if (Input.GetMouseButtonUp(0) &&isStill == true)
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        endPoint.z = 15;
        aC.active = false;
        force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
        rb.AddForce(force * power, ForceMode2D.Impulse);
        PlayerSound(launchSound);
        tl.EndLine();
			  rb.constraints = RigidbodyConstraints2D.None;
    }
  }

  public void PlayerSound(AudioClip clip)
  {
    if(launchable == true){
      mySounds.PlayOneShot(launchSound);
    }
  }

}
