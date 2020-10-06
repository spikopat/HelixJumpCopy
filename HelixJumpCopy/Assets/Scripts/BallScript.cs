using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Rigidbody rb;

    [SerializeField]
    GameObject splashObject;

    [SerializeField]
    Transform splashParent;

    [SerializeField]
    float addForceY;

    [SerializeField]
    ParticleSystem splashParticleSystem;

    bool isForcing;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision) {

        if (!isForcing && collision.gameObject.tag == "RingPiece") {

            SpawnSplashEffect(collision.contacts[0].point);
            SetForceToBall();

        }
    }

    //Particle'ı aktif eder, splash sprite'ı spawnlar ve splash sesini çalar.
    void SpawnSplashEffect(Vector3 spawnPos) {
        splashParticleSystem.Play();
        Instantiate(splashObject, new Vector3(spawnPos.x, spawnPos.y + 0.1f, spawnPos.z), Quaternion.Euler(90, 0, 0), splashParent);
        GameManagers.Sound.InGameAudioSource.PlayOneShot(GameManagers.Sound.splashSound, 1);
    }

    void SetForceToBall() {
        rb.AddForce(new Vector3(0, addForceY, 0), ForceMode.Force);
        isForcing = true;
    }

    //Farklı zeminlerin topa aynı anda force uygulayamaması için spagetti bir çözüm.
    float temp = 0;
    private void Update() {
        if (isForcing) {
            temp += Time.deltaTime;
            if (temp >= 0.5f) {
                isForcing = false;
                temp = 0;
            }
        }
    }

}