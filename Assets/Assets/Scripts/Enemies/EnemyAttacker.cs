using System.Collections;
using Assets.Scripts.Enemies.Bullets;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class EnemyAttacker : Attacker<EnemyBullet>
    {
        private void OnEnable() =>
            StartCoroutine(CooldownAttack());

        private void OnDisable() =>
            StopAllCoroutines();

        public override void Attack()
        {
            var item = Spawner.Spawn(transform);

            item.SetDirection(GetDirection());
        }

        protected override Vector2 GetDirection() =>
            -transform.right;

        protected override IEnumerator CooldownAttack()
        {
            while (enabled)
            {
                yield return Wait;

                Attack();
            }
        }
    }
}