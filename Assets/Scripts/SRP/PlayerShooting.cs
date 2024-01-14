using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab; 
    [SerializeField] int projectileSpeed = 10;
    [SerializeField] Transform firePoint;

    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        // Check for input to shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody RBProjectile = projectile.GetComponent<Rigidbody>();
            RBProjectile.velocity = transform.forward * projectileSpeed;
            // Destroy the projectile after a certain time (for cleanup)
            Destroy(projectile, 2f);
        }
    }
}
