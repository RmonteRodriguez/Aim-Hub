using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public int targetsLeft;
    public int shotsMissed;

    public bool canShoot;

    //UI
    public GameObject summaryUI;
    public GameObject standardUI;
    public GameObject pauseUI;
    public Text shotsMissedText;

    //SFX
    public AudioSource hitSFX;
    public AudioSource missSFX;

    void Start()
    {
        targetsLeft = 15;
        shotsMissed = 0;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (canShoot == true)
            {
                Shoot();
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            Pause();
        }

        if (targetsLeft <= -1)
        {
            pauseUI.SetActive(true);
            standardUI.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            canShoot = false;
        }

        shotsMissedText.text = shotsMissed + " Shots Missed";
        
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.Die();
                targetsLeft--;
                hitSFX.Play();
            }
            else
            {
                shotsMissed++;
                missSFX.Play();
            }
        }
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        standardUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        canShoot = false;
    }

    public void Continue()
    {
        pauseUI.SetActive(false);
        standardUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        canShoot = true;
    }
}