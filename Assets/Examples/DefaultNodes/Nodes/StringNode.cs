using UnityEngine;
using GraphProcessor;

[System.Serializable, NodeMenuItem("String")]
public class StringNode : BaseNode
{
	[Output(name = "Out"), SerializeField]
	public string				output;

	public override string		name => "String";
}
