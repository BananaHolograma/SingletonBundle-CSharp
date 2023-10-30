using Godot;
using Godot.Collections;

public partial class VectorWizard : Node
{
	public Array<Vector2> GenerateRandomDirectionsOnAngleRange(
		Vector2 origin,
		float minAngleRange = 0.0f,
		float maxAngleRange = 360.0f,
		int numDirections = 10
	)
	{
		Array<Vector2> randomDirections = new();
		randomDirections.Resize(numDirections);

		float minAngleInRad = Mathf.DegToRad(minAngleRange);
		float maxAngleInRad = Mathf.DegToRad(maxAngleRange);

		foreach (int _ in GD.Range(numDirections))
		{
			float randomAngle = GenerateRandomAngle(minAngleRange, maxAngleRange);
			randomDirections.Add(origin.Rotated(randomAngle));
		}

		return randomDirections;
	}


	public float GenerateRandomAngle(float minAngleRange = 0.0f, float maxAngleRange = 360.0f)
	{
		return Mathf.Lerp(minAngleRange, maxAngleRange, GD.Randf());
	}

	public Vector2 GenerateRandomDirection()
	{
		RandomNumberGenerator randomNumberGenerator = new();
		return new Vector2(randomNumberGenerator.RandiRange(-1, 1), randomNumberGenerator.RandiRange(-1, 1)).Normalized();
	}

	public Vector2 TranslateXAxisToVector(float axis)
	{
		Vector2 horizontalDirection = Vector2.Zero;

		switch (axis)
		{
			case -1.0f:
				horizontalDirection = Vector2.Left;
				break;

			case 1.0f:
				horizontalDirection = Vector2.Right;
				break;
		}

		return horizontalDirection;
	}

	public Vector2 NormalizeVector(Vector2 value)
	{
		Vector2 direction = NormalizeDiagonalVector(value);

		if (direction.IsEqualApprox(value))
		{
			return value.IsNormalized() ? value : value.Normalized();
		}

		return direction;
	}

	public Vector2 NormalizeDiagonalVector(Vector2 direction)
	{
		if (IsDiagonalDirection(direction))
		{
			return direction * Mathf.Sqrt(2);
		}

		return direction;
	}

	public bool IsDiagonalDirection(Vector2 direction)
	{
		return direction.X != 0 && direction.Y != 0;
	}

	/*
 	*	Also known as the "city distance" or "L1 distance"
	*	It measures the distance between two points as the sum of the absolute differences of their coordinates in each dimension.
	*/
	public float DistanceManhattanV2(Vector2 a, Vector2 b)
	{
		return Mathf.Abs(a.X - b.X) + Mathf.Abs(a.Y - b.Y);
	}

	/* Also known as the "chess distance" or "L∞ distance".
	 * It measures the distance between two points as the greater of the absolute differences of their coordinates in each dimension
	*/

	public float DistanceChebysevV2(Vector2 a, Vector2 b)
	{
		return Mathf.Max(Mathf.Abs(a.X - b.X), Mathf.Abs(a.Y - b.Y));
	}

	public float LengthManhattanV2(Vector2 a)
	{
		return Mathf.Abs(a.X) + Mathf.Abs(a.Y);
	}

	public float LengthChebysevV2(Vector2 a, Vector2 b)
	{
		return Mathf.Max(Mathf.Abs(a.X), Mathf.Abs(a.Y));
	}

	/*
	* This function calculates the closest point on a line segment (defined by two points, a and b) to a third point c. 
	* It also clamps the result to ensure that the closest point lies within the line segment.
	*/
	public Vector2 ClosestPointOnLineClampedV2(Vector2 a, Vector2 b, Vector2 c)
	{
		b = (b - a).Normalized();
		c -= a;

		return a + b * Mathf.Clamp(c.Dot(b), 0.0f, 1.0f);
	}

	/*
	*	This function is similar to the previous one but does not clamp the result. 
	*	It calculates the closest point on the line segment defined by a and b to a third point c.
	*	It uses the same vector operations as the previous closest_point_on_line_clamped_v2 function.
	*/
	public Vector2 ClosestPointOnLineV2(Vector2 a, Vector2 b, Vector2 c)
	{
		b = (b - a).Normalized();
		c -= a;

		return a + b * c.Dot(b);
	}

	/**
	* Vector3 versions of the above calculation functions
	*/
	public float DistanceManhattanV3(Vector3 a, Vector3 b)
	{
		return Mathf.Abs(a.X - b.X) + Mathf.Abs(a.Y - b.Y) + Mathf.Abs(a.Z - b.Z);
	}

	public float DistanceChebysevV3(Vector3 a, Vector3 b)
	{
		return Mathf.Max(Mathf.Abs(a.X - b.X), Mathf.Max(Mathf.Abs(a.Y - b.Y), Mathf.Abs(a.Z - b.Z)));
	}

	public float LengthManhattanV3(Vector3 a)
	{
		return Mathf.Abs(a.X) + Mathf.Abs(a.Y) + Mathf.Abs(a.Z);
	}

	public float LengthChebysevV3(Vector3 a, Vector3 b)
	{
		return Mathf.Max(Mathf.Abs(a.X), Mathf.Max(Mathf.Abs(a.Y), Mathf.Abs(a.Z)));
	}

	public Vector3 ClosestPointOnLineClampedV3(Vector3 a, Vector3 b, Vector3 c)
	{
		b = (b - a).Normalized();
		c -= a;

		return a + b * Mathf.Clamp(c.Dot(b), 0.0f, 1.0f);
	}

	public Vector3 ClosestPointOnLineV3(Vector3 a, Vector3 b, Vector3 c)
	{
		b = (b - a).Normalized();
		c -= a;

		return a + b * c.Dot(b);
	}

	public float ClosestPointOnLineNormalizedV3(Vector3 a, Vector3 b, Vector3 c)
	{
		b -= a;
		c -= a;

		return c.Dot(b.Normalized()) / b.Length();
	}
}
