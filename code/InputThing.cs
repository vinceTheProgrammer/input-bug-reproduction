using Sandbox;
using Sandbox.Diagnostics;

public sealed class InputThing : Component
{
	private Logger Logger = new Logger( "InputThing: " );
	protected override void OnUpdate()
	{
		Logger.Info( "Forward button origin: " + Input.GetButtonOrigin( "Forward" ) );
		if (Input.Down("Forward"))
		{
		GameObject.Transform.Position += new Vector3( 0, (float) 0.1, 0 );
		}
	}
}
