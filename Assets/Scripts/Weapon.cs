using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
	[SerializeField] private float coolDown;
	[SerializeField] private float bulletForce;
	[SerializeField] private float rotationSpeed;

	[SerializeField] private GameObject bullet;
	[SerializeField] private TrajectoryRenderer trajectoryRenderer;
	[SerializeField] private Transform rotatingPart;
	[SerializeField] private Transform shootingPoint;
	[SerializeField] private Vector3 rotationBounds;
	private Vector3 m_rotationVector3 = new Vector3();

	private bool m_isUsing;

	public virtual void Enable()
	{
		m_isUsing = true;
		trajectoryRenderer.gameObject.SetActive(true);
	}

	public virtual void Disable()
	{
		m_isUsing = false;
		trajectoryRenderer.gameObject.SetActive(false);
	}

	public virtual void Rotate(Vector2 _rotationEuler)
	{
		m_rotationVector3.y = _rotationEuler.x;
		m_rotationVector3.x = _rotationEuler.y;
	}

	public virtual void Update()
	{
		if (m_isUsing) trajectoryRenderer.ShowTrajectory(shootingPoint.position, ShootDirection());
		rotatingPart.Rotate(m_rotationVector3 * Time.deltaTime * rotationSpeed);
		rotatingPart.rotation =
			Quaternion.Euler(ClampAngle(rotatingPart.eulerAngles.x, -rotationBounds.x, 8),
				ClampAngle(rotatingPart.eulerAngles.y, -rotationBounds.y, rotationBounds.y), 0);
	}

	float ClampAngle(float angle, float from, float to)
	{
		// accepts e.g. -80, 80
		if (angle < 0f) angle = 360 + angle;
		if (angle > 180f) return Mathf.Max(angle, 360+from);
		return Mathf.Min(angle, to);
	}
	
	public virtual Vector3 ShootDirection()
	{
		return shootingPoint.transform.forward * bulletForce;
	}

	public virtual void Shoot()
	{
		Rigidbody _bullet = Instantiate(bullet, shootingPoint.position, Quaternion.identity).GetComponent<Rigidbody>();
		_bullet.AddForce(ShootDirection(), ForceMode.VelocityChange);
	}
}