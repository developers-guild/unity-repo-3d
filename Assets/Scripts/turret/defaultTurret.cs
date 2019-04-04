using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class defaultTurret : baseTurretScript
{
    public float interval = 1.0f;
    public float damage = 0.0f;

    private float mTotalTime = 0.0f;

    public override void Attack()
    {
        if(mTotalTime > interval)
        {
            mTotalTime = 0.0f;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(GetEnemyTag(tag))
                .Where(c => CalculateDistance(c) <= range)
                .ToArray();
            if (enemies.Length == 0) return;
            var closest = enemies
                .Select(c => new KeyValuePair<GameObject, float>(c, CalculateDistance(c)))
                .OrderBy(c => c.Value)
                .FirstOrDefault();
            ShootPlayer(closest.Key);
        }
        else
        {
            mTotalTime += Time.deltaTime;
        }
    }

    private void ShootPlayer(GameObject player)
    {
        // TODO: FIX THIS
        var baseProj = GameObject.Find("Projectile");
        var proj = Object.Instantiate(baseProj);
        proj.name = $"{name}_Projectile{Time.time}";



        var aimProj = proj.GetComponent<projectileAim>();
        aimProj.transform.position.Set(4f, 2f, -4f);
        aimProj.target = player.transform;
        aimProj.isMoving = true;



        var bluePlayer = GameObject.Find("BluePlayer");
        if (bluePlayer != null)
        {
            var bphealth = bluePlayer.GetComponent<PlayerHealth>();
            bphealth.TakeDamage(25);
        }

    }

    private float CalculateDistance(GameObject entity)
    {
        return Vector3.Distance(transform.position, entity.transform.position);
    }
}
